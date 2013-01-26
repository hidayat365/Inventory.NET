#include <string>
#include <vector>
#include <Windows.h>
#include "utils.h"
#include <sstream>
#include <iostream>
#include "resource.h"

int main()
{
    std::string publicKey;
    std::string privateKey;

    std::vector<char> vecPrivate;   

    utils::SaveResToVector(L"PRIVATE_KEY", IDR_FILE_PRIVATE_KEY, &vecPrivate );

    //this is an example of how to generate public and private keys
    //you need to save them in .rc files or somewhere else after they are first generated
    if (vecPrivate.empty())
    {
        utils::RsaGenerateStringKeys(publicKey, privateKey);
        std::vector<char> vecPublic(publicKey.begin(), publicKey.end());
        vecPrivate.assign(privateKey.begin(), privateKey.end());
        utils::SaveVectorToFile(L"keys\\private.bin", vecPrivate);
        utils::SaveVectorToFile(L"keys\\public.bin", vecPublic);
    }
    else
    {
        privateKey.assign(vecPrivate.begin(), vecPrivate.end());
    }
    
    std::string sign;
    
    std::vector<char> smallFile;
    std::string serialKey;

    //Input the hardware serial key, that your client application will give you
    std::cout << "Input your serial key here : ";
    std::cin >> serialKey;
    
    //make it vector and sign using utils
    std::vector<char> hardwareSerialKey(serialKey.begin(), serialKey.end());
    utils::RsaSignVector(privateKey, hardwareSerialKey, sign);

    //save signed value to the file and send the file to user
    std::vector<char> vec(sign.begin(), sign.end());
    utils::SaveVectorToFile(L"License.dat", vec);

    std::cout << "Your license.dat file was saved in program's directory" << std::endl;
    std::cout << "Press any key...";
    std::cin.get();

    return 0;
}