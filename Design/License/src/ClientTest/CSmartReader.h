#ifndef __CSMART_READER__
#define __CSMART_READER__

#include <map>
#include <Windows.h>

#define OUT_BUFFER_SIZE IDENTIFY_BUFFER_SIZE + 16

#define INDEX_ATTRIB_INDEX									0
#define INDEX_ATTRIB_UNKNOWN1								1
#define INDEX_ATTRIB_UNKNOWN2								2
#define INDEX_ATTRIB_VALUE									3
#define INDEX_ATTRIB_WORST									4
#define INDEX_ATTRIB_RAW									5

typedef std::map<DWORD,LPVOID> SMARTINFOMAP;

typedef struct 
{
    WORD wGenConfig;
    WORD wNumCyls;
    WORD wReserved;
    WORD wNumHeads;
    WORD wBytesPerTrack;
    WORD wBytesPerSector;
    WORD wSectorsPerTrack;
    WORD wVendorUnique[3];
    CHAR sSerialNumber[20];
    WORD wBufferType;
    WORD wBufferSize;
    WORD wECCSize;
    BYTE sFirmwareRev[8];
    BYTE sModelNumber[39];
    WORD wMoreVendorUnique;
    WORD wDoubleWordIO;
    WORD wCapabilities;
    WORD wReserved1;
    WORD wPIOTiming;
    WORD wDMATiming;
    WORD wBS;
    WORD wNumCurrentCyls;
    WORD wNumCurrentHeads;
    WORD wNumCurrentSectorsPerTrack;
    WORD ulCurrentSectorCapacity;
    WORD wMultSectorStuff;
    DWORD ulTotalAddressableSectors;
    WORD wSingleWordDMA;
    WORD wMultiWordDMA;
    BYTE bReserved[127];
}ST_IDSECTOR;

typedef struct
{
    BOOL m_bCritical;
    BYTE m_ucAttribId;
    std::wstring m_csAttribName;
    std::wstring m_csAttribDetails;
}ST_SMART_DETAILS;

typedef struct
{
    BYTE  bDriverError;
    BYTE  bIDEStatus;
    BYTE  bReserved[2];
    DWORD dwReserved[2];
} ST_DRIVERSTAT;

typedef struct
{
    DWORD      cBufferSize;
    ST_DRIVERSTAT DriverStatus;
    BYTE       bBuffer[1];
} ST_ATAOUTPARAM;

typedef std::map<BYTE,ST_SMART_DETAILS> SMARTDETAILSMAP;

typedef struct
{
    BYTE m_ucAttribIndex;
    DWORD m_dwAttribValue;
    BYTE m_ucValue;
    BYTE m_ucWorst;
    DWORD m_dwThreshold;
}ST_SMART_INFO;

typedef struct
{
    GETVERSIONINPARAMS m_stGVIP;
    ST_IDSECTOR m_stInfo;
    ST_SMART_INFO m_stSmartInfo[256];
    BYTE m_ucSmartValues;
    BYTE m_ucDriveIndex;
    std::wstring m_csErrorString;
}ST_DRIVE_INFO;

class CSmartReader
{
    CSmartReader(const CSmartReader & );
    CSmartReader & operator = (const CSmartReader&);

    VOID InitAll();
    VOID CloseAll();
    VOID FillAttribGenericDetails();
    VOID ConvertString(PCHAR pString,DWORD cbData);

    BOOL ReadSMARTInfo(BYTE ucDriveIndex);
    BOOL IsSmartEnabled(HANDLE hDevice,UCHAR ucDriveIndex);
    BOOL CollectDriveInfo(HANDLE hDevice,UCHAR ucDriveIndex);
    BOOL ReadSMARTAttributes(HANDLE hDevice,UCHAR ucDriveIndex);

    ST_SMART_DETAILS m_stSmartDetails;
    SMARTINFOMAP m_oSmartInfo;
    SMARTDETAILSMAP m_oSMARTDetails;

public:
    CSmartReader();
    ~CSmartReader();

    BOOL ReadSMARTValuesForAllDrives();
    ST_SMART_DETAILS *GetSMARTDetails(BYTE ucAttribIndex);
    ST_SMART_INFO *GetSMARTValue(BYTE ucDriveIndex,BYTE ucAttribIndex);
    ST_DRIVE_INFO *GetDriveInfo(BYTE ucDriveIndex);

    BYTE m_ucDrivesWithInfo; // Number of drives with information read
    BYTE m_ucDrives;// Fixed HDD's
    ST_DRIVE_INFO m_stDrivesInfo[32];
};

#endif