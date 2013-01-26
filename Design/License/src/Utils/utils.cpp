#include "utils.h"
#include "hex.h"
#include "rsa.h"
#include "osrng.h"
#include "pssr.h"
#include "secblock.h"
#include <exception>

namespace utils
{
    void RsaGenerateStringKeys(std::string & publicKeyStr, std::string & privateKeyStr)
    {
        // Pseudo Random Number Generator
        CryptoPP::AutoSeededRandomPool rng;

        // Generate Parameters
        CryptoPP::InvertibleRSAFunction params;
        params.GenerateRandomWithKeySize( rng, 1536 );

        CryptoPP::RSA::PrivateKey privateKey( params );
        CryptoPP::RSA::PublicKey publicKey( params );

        CryptoPP::HexEncoder encoder;

        // save public Key
        encoder.Attach( new CryptoPP::StringSink( publicKeyStr ) );
        publicKey.Save( encoder );

        // save private Key
        encoder.Attach( new CryptoPP::StringSink( privateKeyStr ) );
        privateKey.Save( encoder );
    }

    inline void wchar2str(const wchar_t * str, size_t strSize, std::vector<char> * res, UINT cpId = CP_ACP)
    {
        if(!strSize)
            return;
        res->resize(strSize + 1);//it is enough in 99%
        while(1)
        {
            int size = WideCharToMultiByte(cpId, 0, str, (int)strSize, &(*res)[0], (int)res->size(), 0, 0);
            if(size)
            {
                res->resize(size + 1);
                return;
            }
            DWORD error = ::GetLastError();
            if(error != ERROR_INSUFFICIENT_BUFFER)
                throw std::exception(utils::FormatError(error).c_str());
            size = WideCharToMultiByte(cpId, 0, str, (int)strSize, 0, 0, 0, 0);
            if(!size)
                throw std::exception(utils::FormatError(::GetLastError()).c_str());
            res->resize(size + 1);
        }
    }

    inline void wchar2str_unthrowable(const wchar_t * str, size_t strSize, std::vector<char> * res, UINT cpId = CP_ACP)
    {
        try
        {
            wchar2str(str, strSize, res, cpId);
        }
        catch(const std::exception& ){}//for capability
    }

    std::string wstring2string(const std::wstring &from)
    {
        std::vector<char> res;
        wchar2str_unthrowable(from.c_str(), from.size(), &res);
        return res.empty()?"":&res[0];
    }

    std::string wstring2string(const wchar_t* from, size_t size)
    {
        std::vector<char> res;
        wchar2str_unthrowable(from, size, &res);
        return res.empty()?"":&res[0];
    }

    void SaveVectorToFile(const std::wstring& fileName, const std::vector<char>& data)
    {
        HANDLE hFile = CreateFileW(fileName.c_str(), GENERIC_WRITE, FILE_SHARE_READ, NULL, CREATE_ALWAYS, 0, NULL);
        if(hFile == INVALID_HANDLE_VALUE)
            throw std::logic_error("SaveVectorToFile : can't open file " + wstring2string(fileName));
        utils::CHandleGuard fileGuard(hFile);
        DWORD bytesWriten = 0;
        if(!WriteFile(hFile, &data[0], (DWORD)data.size(), &bytesWriten, 0))
            throw std::logic_error("SaveVectorToFile : can't write to file " + wstring2string(fileName));
    }

    void LoadFileToVector(const std::wstring& fileName, std::vector<char>& data)
    {
        HANDLE hFile = CreateFileW(fileName.c_str(), GENERIC_READ, FILE_SHARE_READ|FILE_SHARE_WRITE|FILE_SHARE_DELETE, NULL, OPEN_EXISTING, 0, NULL);
        if(hFile == INVALID_HANDLE_VALUE)
            throw std::logic_error(__FUNCTION__" : can't open file " + wstring2string(fileName));
        utils::CHandleGuard fileGuard(hFile);
        LoadFileToVector(fileGuard.get(),data);
    }

    void LoadFileToVector(HANDLE hFile, std::vector<char>& data)
    {
        if(hFile == INVALID_HANDLE_VALUE)
            throw std::logic_error(__FUNCTION__" : can't open file ");
        DWORD fileSize = GetFileSize(hFile, NULL);
        if(fileSize == INVALID_FILE_SIZE)
            throw std::logic_error(__FUNCTION__" : can't get file size for ");

        if (!fileSize)
            return;

        data.resize(fileSize);
        DWORD bytesRead = 0;

        if(!ReadFile(hFile, &data[0], fileSize, &bytesRead, 0) || bytesRead != fileSize)
            throw std::logic_error(__FUNCTION__" : can't read file ");
    }

    void RsaSignVector(const std::string & privateKeyStrHex, const std::vector<char> & vec, std::string & sign)
    {
        // Pseudo Random Number Generator
        CryptoPP::AutoSeededRandomPool rng;
        // Generate Parameters
        CryptoPP::InvertibleRSAFunction params;
        params.GenerateRandomWithKeySize( rng, 1536 );

        CryptoPP::HexDecoder decoder;
        decoder.Put( (byte*)privateKeyStrHex.c_str(), privateKeyStrHex.size() );
        decoder.MessageEnd();

        CryptoPP::RSA::PrivateKey privateKey; // Private
        privateKey.Load( decoder );


        CryptoPP::RSASS<CryptoPP::PSS, CryptoPP::SHA1>::Signer signer( privateKey );

        size_t length = signer.MaxSignatureLength();
        CryptoPP::SecByteBlock signature( length );

        // Sign message
        signer.SignMessage( rng, (const byte*) utils::GetBeginOf(vec),
            vec.size(), signature );

        sign  = utils::wstring2string(utils::ToHexString<byte>(signature, signature.size()));
    }

    void SaveResToVector(const std::wstring& resName, int resId, std::vector<char>* target)
    {
        HMODULE hMod = GetModuleHandleW( NULL );
        if(!hMod)
            throw std::runtime_error("Can't get module handle: "+ utils::FormatError(GetLastError()) + "\n");

        HRSRC hResource = FindResourceW(hMod, MAKEINTRESOURCE(resId), resName.c_str());
        if(!hResource)
            return;

        HGLOBAL hXlatTable = LoadResource(hMod, hResource);
        if(!hXlatTable)
            throw std::runtime_error("Can't load resource: "+ utils::FormatError(GetLastError()) + "\n");

        char far* pData = (char far *)LockResource(hXlatTable);
        if(!pData)
            throw std::runtime_error("Can't lock resource: "+ utils::FormatError(GetLastError()) + "\n");

        DWORD resourceSize = SizeofResource( hMod, hResource);
        target->resize(resourceSize);

        memcpy(utils::GetBeginOf(*target),pData,resourceSize);
    }

    bool RsaVerifyVector(const std::string & publicKeyStrHex, const std::string& source, const std::vector<char>& sign)
    {
        CryptoPP::HexDecoder decoder;
        decoder.Put( (byte*)publicKeyStrHex.c_str(), publicKeyStrHex.size() );
        decoder.MessageEnd();

        CryptoPP::RSA::PublicKey publicKey;
        publicKey.Load( decoder );

        // Verifier object
        CryptoPP::RSASS<CryptoPP::PSS, CryptoPP::SHA1>::Verifier verifier( publicKey );

        std::vector<char> rawSignature;
        std::string signStr(utils::GetBeginOf(sign), sign.size());
        utils::FromHexString(utils::string2wstring(signStr), &rawSignature);
        // Verify
        const char * pData = utils::GetBeginOf(source);
        return verifier.VerifyMessage( (const byte*) pData,
            source.size(), (const byte*) utils::GetBeginOf(rawSignature), rawSignature.size() );
    }

    std::wstring string2wstring(const std::string &from)
    {
        std::vector<wchar_t> res;
        char2wstr_unthrowable(from.c_str(), from.size(), &res);
        return res.empty()?L"":&res[0];
    }
}