#include "CSmartReader.h"

#define DRIVE_HEAD_REG	0xA0

CSmartReader::CSmartReader()
{
    InitAll();
    FillAttribGenericDetails();
}

CSmartReader::~CSmartReader()
{
    CloseAll();
}

VOID CSmartReader::InitAll()
{
    m_ucDrivesWithInfo=m_ucDrives=0;
    m_oSmartInfo.clear();
}

VOID CSmartReader::CloseAll()
{
    InitAll();
}

BOOL CSmartReader::ReadSMARTValuesForAllDrives()
{
    DWORD dwBits, dwBitVal;
    BOOL bFlag=0;
    WCHAR wDrives[MAX_PATH]={0};
    BYTE ucDriveIndex=0, bDriveIndex=0;

    CloseAll();
    dwBits=GetLogicalDrives();
    dwBitVal=1;
    bDriveIndex=0;
    bFlag=(dwBits & dwBitVal);
    while(bDriveIndex < 32)
    {
        if(bFlag)
        {
            wsprintf(wDrives,L"%c:\\",'A'+bDriveIndex);
            switch(GetDriveType(wDrives))
            {
            case DRIVE_FIXED:
                ucDriveIndex=bDriveIndex-2;
                if(ReadSMARTInfo(ucDriveIndex))
                    m_ucDrivesWithInfo++;
                m_ucDrives++;
                break;

            default:
                break;
            }
        }
        dwBitVal=dwBitVal*2;
        bFlag=(dwBits & dwBitVal);
        ++bDriveIndex;
    }
    if(m_ucDrives==m_ucDrivesWithInfo)
        return TRUE;
    else
        return FALSE;
}

BOOL CSmartReader::ReadSMARTInfo(BYTE ucDriveIndex)
{
    HANDLE hDevice=NULL;
    WCHAR wTempDriveName[MAX_PATH]={0};
    BOOL bRet=FALSE;
    DWORD dwRet=0;

    wsprintf(wTempDriveName,L"\\\\.\\PHYSICALDRIVE%d",ucDriveIndex);
    hDevice=CreateFile(wTempDriveName,GENERIC_READ|GENERIC_WRITE,FILE_SHARE_READ|FILE_SHARE_WRITE,NULL,OPEN_EXISTING,FILE_ATTRIBUTE_SYSTEM,NULL);
    if(hDevice!=INVALID_HANDLE_VALUE)
    {
        bRet=DeviceIoControl(hDevice,SMART_GET_VERSION,NULL,0,&m_stDrivesInfo[ucDriveIndex].m_stGVIP,sizeof(GETVERSIONINPARAMS),&dwRet,NULL);
        if(bRet)
        {			
            if((m_stDrivesInfo[ucDriveIndex].m_stGVIP.fCapabilities & CAP_SMART_CMD)==CAP_SMART_CMD)
            {
                if(IsSmartEnabled(hDevice,ucDriveIndex))
                {
                    bRet=CollectDriveInfo(hDevice,ucDriveIndex);
                    bRet=ReadSMARTAttributes(hDevice,ucDriveIndex);
                }
            }
        }
        CloseHandle(hDevice);
    }
    return bRet;
}

BOOL CSmartReader::IsSmartEnabled(HANDLE hDevice,UCHAR ucDriveIndex)
{
    SENDCMDINPARAMS cmdInParams={0};
    SENDCMDOUTPARAMS smdOutParams={0};
    DWORD dwRet=0;
    BOOL bRet=FALSE;

    cmdInParams.cBufferSize=0;
    cmdInParams.bDriveNumber =ucDriveIndex;
    cmdInParams.irDriveRegs.bFeaturesReg=ENABLE_SMART;
    cmdInParams.irDriveRegs.bSectorCountReg = 1;
    cmdInParams.irDriveRegs.bSectorNumberReg = 1;
    cmdInParams.irDriveRegs.bCylLowReg = SMART_CYL_LOW;
    cmdInParams.irDriveRegs.bCylHighReg = SMART_CYL_HI;
    cmdInParams.irDriveRegs.bDriveHeadReg = DRIVE_HEAD_REG;
    cmdInParams.irDriveRegs.bCommandReg = SMART_CMD;

    bRet=DeviceIoControl(hDevice,SMART_SEND_DRIVE_COMMAND,&cmdInParams,sizeof(cmdInParams),&smdOutParams,sizeof(smdOutParams),&dwRet,NULL);
    if(!bRet)
    {
        dwRet=GetLastError();
    }
    return bRet;
}

BOOL CSmartReader::CollectDriveInfo(HANDLE hDevice,UCHAR ucDriveIndex)
{
    BOOL bRet = FALSE;
    SENDCMDINPARAMS stCIP = {0};
    DWORD dwRet = 0;
    char szOutput[OUT_BUFFER_SIZE] = {0};

    stCIP.cBufferSize=IDENTIFY_BUFFER_SIZE;
    stCIP.bDriveNumber =ucDriveIndex;
    stCIP.irDriveRegs.bFeaturesReg=0;
    stCIP.irDriveRegs.bSectorCountReg = 1;
    stCIP.irDriveRegs.bSectorNumberReg = 1;
    stCIP.irDriveRegs.bCylLowReg = 0;
    stCIP.irDriveRegs.bCylHighReg = 0;
    stCIP.irDriveRegs.bDriveHeadReg = DRIVE_HEAD_REG;
    stCIP.irDriveRegs.bCommandReg = ID_CMD;

    bRet=DeviceIoControl(hDevice,SMART_RCV_DRIVE_DATA,&stCIP,sizeof(stCIP),szOutput,OUT_BUFFER_SIZE,&dwRet,NULL);
    if(bRet)
    {
        CopyMemory(&m_stDrivesInfo[ucDriveIndex].m_stInfo, szOutput+16, sizeof(ST_IDSECTOR));
        ConvertString(m_stDrivesInfo[ucDriveIndex].m_stInfo.sSerialNumber, 20);
    }
    else
    {
        dwRet=GetLastError();
    }
    return bRet;
}

VOID CSmartReader::ConvertString(PCHAR pString,DWORD cbData)
{
    CHAR tempString[MAX_PATH] = {0};
    for(DWORD i = 0; i < cbData; i += 2)
    {
        tempString[i] = pString[i + 1];
        tempString[i + 1] = pString[i];
    }
    memcpy(pString,tempString,cbData);
}

VOID CSmartReader::FillAttribGenericDetails()
{
    WCHAR szINIFileName[MAX_PATH]={0};
    WCHAR szKeyName[MAX_PATH]={0};
    WCHAR szValue[MAX_PATH]={0};

    int nC1,nSmartAttribs;
    ST_SMART_DETAILS stSD;

    m_oSMARTDetails.clear();
    {
        GetModuleFileName(NULL,szINIFileName,MAX_PATH);
        szINIFileName[lstrlen(szINIFileName)-3]=0;
        lstrcat(szINIFileName,L"ini");
    }
    nSmartAttribs=GetPrivateProfileInt(L"General",L"Max Attributes",0,szINIFileName);
    for(nC1=0;nC1<nSmartAttribs;++nC1)
    {
        wsprintf(szKeyName,L"Attrib%d",nC1);
        stSD.m_ucAttribId=GetPrivateProfileInt(szKeyName,L"Id",0,szINIFileName);
        stSD.m_bCritical=GetPrivateProfileInt(szKeyName,L"Critical",0,szINIFileName);
        GetPrivateProfileString(szKeyName,L"Name",L"",szValue,1024,szINIFileName);
        stSD.m_csAttribName=szValue;
        GetPrivateProfileString(szKeyName,L"Details",L"",szValue,1024,szINIFileName);
        stSD.m_csAttribDetails=szValue;
        m_oSMARTDetails.insert(SMARTDETAILSMAP::value_type(stSD.m_ucAttribId,stSD));
    }
}

ST_SMART_DETAILS *CSmartReader::GetSMARTDetails(BYTE ucAttribIndex)
{
    SMARTDETAILSMAP::iterator pIt;
    ST_SMART_DETAILS *pRet=NULL;

    pIt=m_oSMARTDetails.find(ucAttribIndex);
    if(pIt!=m_oSMARTDetails.end())
        pRet=&pIt->second;

    return pRet;
}

ST_SMART_INFO *CSmartReader::GetSMARTValue(BYTE ucDriveIndex,BYTE ucAttribIndex)
{
    SMARTINFOMAP::iterator pIt;
    ST_SMART_INFO *pRet=NULL;

    pIt=m_oSmartInfo.find(MAKELPARAM(ucAttribIndex,ucDriveIndex));
    if(pIt!=m_oSmartInfo.end())
        pRet=(ST_SMART_INFO *)pIt->second;
    return pRet;
}

BOOL CSmartReader::ReadSMARTAttributes(HANDLE hDevice,UCHAR ucDriveIndex)
{
    SENDCMDINPARAMS stCIP={0};
    DWORD dwRet=0;
    BOOL bRet=FALSE;
    BYTE	szAttributes[sizeof(ST_ATAOUTPARAM) + READ_ATTRIBUTE_BUFFER_SIZE - 1];
    UCHAR ucT1;
    PBYTE pT1,pT3;PDWORD pT2;
    ST_SMART_INFO *pSmartValues;

    stCIP.cBufferSize=READ_ATTRIBUTE_BUFFER_SIZE;
    stCIP.bDriveNumber =ucDriveIndex;
    stCIP.irDriveRegs.bFeaturesReg=READ_ATTRIBUTES;
    stCIP.irDriveRegs.bSectorCountReg = 1;
    stCIP.irDriveRegs.bSectorNumberReg = 1;
    stCIP.irDriveRegs.bCylLowReg = SMART_CYL_LOW;
    stCIP.irDriveRegs.bCylHighReg = SMART_CYL_HI;
    stCIP.irDriveRegs.bDriveHeadReg = DRIVE_HEAD_REG;
    stCIP.irDriveRegs.bCommandReg = SMART_CMD;
    bRet=DeviceIoControl(hDevice,SMART_RCV_DRIVE_DATA,&stCIP,sizeof(stCIP),szAttributes,sizeof(ST_ATAOUTPARAM) + READ_ATTRIBUTE_BUFFER_SIZE - 1,&dwRet,NULL);
    if(bRet)
    {
        m_stDrivesInfo[ucDriveIndex].m_ucSmartValues=0;
        m_stDrivesInfo[ucDriveIndex].m_ucDriveIndex=ucDriveIndex;
        pT1=(PBYTE)(((ST_ATAOUTPARAM*)szAttributes)->bBuffer);
        for(ucT1=0;ucT1<30;++ucT1)
        {
            pT3=&pT1[2+ucT1*12];
            pT2=(PDWORD)&pT3[INDEX_ATTRIB_RAW];
            pT3[INDEX_ATTRIB_RAW+2]=pT3[INDEX_ATTRIB_RAW+3]=pT3[INDEX_ATTRIB_RAW+4]=pT3[INDEX_ATTRIB_RAW+5]=pT3[INDEX_ATTRIB_RAW+6]=0;
            if(pT3[INDEX_ATTRIB_INDEX]!=0)
            {
                pSmartValues=&m_stDrivesInfo[ucDriveIndex].m_stSmartInfo[m_stDrivesInfo[ucDriveIndex].m_ucSmartValues];
                pSmartValues->m_ucAttribIndex=pT3[INDEX_ATTRIB_INDEX];
                pSmartValues->m_ucValue=pT3[INDEX_ATTRIB_VALUE];
                pSmartValues->m_ucWorst=pT3[INDEX_ATTRIB_WORST];
                pSmartValues->m_dwAttribValue=pT2[0];
                pSmartValues->m_dwThreshold=MAXDWORD;
                m_oSmartInfo[MAKELPARAM(pSmartValues->m_ucAttribIndex,ucDriveIndex)]=pSmartValues;
                m_stDrivesInfo[ucDriveIndex].m_ucSmartValues++;
            }
        }
    }
    else
        dwRet=GetLastError();

    stCIP.irDriveRegs.bFeaturesReg=READ_THRESHOLDS;
    stCIP.cBufferSize=READ_THRESHOLD_BUFFER_SIZE; // Is same as attrib size
    bRet=DeviceIoControl(hDevice,SMART_RCV_DRIVE_DATA,&stCIP,sizeof(stCIP),szAttributes,sizeof(ST_ATAOUTPARAM) + READ_ATTRIBUTE_BUFFER_SIZE - 1,&dwRet,NULL);
    if(bRet)
    {
        pT1=(PBYTE)(((ST_ATAOUTPARAM*)szAttributes)->bBuffer);
        for(ucT1=0;ucT1<30;++ucT1)
        {
            pT2=(PDWORD)&pT1[2+ucT1*12+5];
            pT3=&pT1[2+ucT1*12];
            pT3[INDEX_ATTRIB_RAW+2]=pT3[INDEX_ATTRIB_RAW+3]=pT3[INDEX_ATTRIB_RAW+4]=pT3[INDEX_ATTRIB_RAW+5]=pT3[INDEX_ATTRIB_RAW+6]=0;
            if(pT3[0]!=0)
            {
                pSmartValues=GetSMARTValue(ucDriveIndex,pT3[0]);
                if(pSmartValues)
                    pSmartValues->m_dwThreshold=pT2[0];
            }
        }
    }
    return bRet;
}

ST_DRIVE_INFO *CSmartReader::GetDriveInfo(BYTE ucDriveIndex)
{
    return &m_stDrivesInfo[ucDriveIndex];
}
