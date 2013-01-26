// ClientTest.cpp : Defines the entry point for the console application.
//

#include "CSmartReader.h"
#include <sstream>
#include <iostream>
#include "utils.h"
#include <vector>
#include "resource.h"


int main()
{
    std::string publicKey;
    std::vector<char> vecPublic;
    utils::SaveResToVector(L"PUBLIC_KEY", IDR_FILE_PUBLIC_KEY, &vecPublic);
    if (vecPublic.empty())
    {
        std::cout << "Cant find public key\nPress Any key..." << std::endl;
        std::cin.get();
        return 0;
    }
    publicKey.assign(vecPublic.begin(), vecPublic.end());
    CSmartReader reader;
    
    ST_IDSECTOR *pSectorInfo = NULL;
    
    reader.ReadSMARTValuesForAllDrives();
    
    pSectorInfo=&reader.m_stDrivesInfo[0].m_stInfo;
    
    std::string str(pSectorInfo->sSerialNumber);

    std::stringstream trimmer;
    trimmer << str;
    trimmer >> str;

    std::cout << "Your hardware Serial Key is : " << str << std::endl;
    
    try
    {
        std::vector<char> vec;
        const std::wstring fileName = L"License.dat";
        utils::LoadFileToVector(fileName, vec);

        if (utils::RsaVerifyVector(publicKey, str, vec))
        {
            std::cout << "License is valid. Continue working" << std::endl;
        }
        else
        {
            std::cout << "License is invalid. Program is being closed" << std::endl;
        }
    }
    catch(const std::logic_error& ex)
    {
        std::cout << "You do not have license.dat file installed. Please put it in program dir." << std::endl;
    }



    std::cout << "Press any key...";
    std::cin.get();

	return 0;
}

