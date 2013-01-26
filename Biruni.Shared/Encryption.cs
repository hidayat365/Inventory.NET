using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Biruni.Shared.Logging;

namespace Biruni.Shared
{
    public enum EncryptionAlgorithm { Des = 1, Rc2, Rijndael, TripleDes };

    public class EncryptTransformer
    {
        private EncryptionAlgorithm algorithmID;
        private byte[] initVec;
        private byte[] encKey;

        internal EncryptTransformer(EncryptionAlgorithm algId)
        {
            //Save the algorithm being used.
            algorithmID = algId;
        }

        internal byte[] IV
        {
            get { return initVec; }
            set { initVec = value; }
        }
        internal byte[] Key
        {
            get { return encKey; }
        }
        
        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            // Pick the provider.
            switch (algorithmID)
            {
                case EncryptionAlgorithm.Des:
                {
                    DES des = new DESCryptoServiceProvider();
                    des.Mode = CipherMode.CBC;

                    // See if a key was provided
                    if (null == bytesKey)
                    {
                        encKey = des.Key;
                    }
                    else
                    {
                        des.Key = bytesKey;
                        encKey = des.Key;
                    }
                    // See if the client provided an initialization vector
                    if (null == initVec)
                    { // Have the algorithm create one
                        initVec = des.IV;
                    }
                    else
                    { //No, give it to the algorithm
                        des.IV = initVec;
                    }
                    return des.CreateEncryptor();
                }
                case EncryptionAlgorithm.TripleDes:
                {
                    TripleDES des3 = new TripleDESCryptoServiceProvider();
                    des3.Mode = CipherMode.CBC;
                    // See if a key was provided
                    if (null == bytesKey)
                    {
                        encKey = des3.Key;
                    }
                    else
                    {
                        des3.Key = bytesKey;
                        encKey = des3.Key;
                    }
                    // See if the client provided an IV
                    if (null == initVec)
                    { //Yes, have the alg create one
                        initVec = des3.IV;
                    }
                    else
                    { //No, give it to the alg.
                        des3.IV = initVec;
                    }
                    return des3.CreateEncryptor();
                }
                case EncryptionAlgorithm.Rc2:
                {
                    RC2 rc2 = new RC2CryptoServiceProvider();
                    rc2.Mode = CipherMode.CBC;
                    // Test to see if a key was provided
                    if (null == bytesKey)
                    {
                        encKey = rc2.Key;
                    }
                    else
                    {
                        rc2.Key = bytesKey;
                        encKey = rc2.Key;
                    }
                    // See if the client provided an IV
                    if (null == initVec)
                    { //Yes, have the alg create one
                        initVec = rc2.IV;
                    }
                    else
                    { //No, give it to the alg.
                        rc2.IV = initVec;
                    }
                    return rc2.CreateEncryptor();
                }
                case EncryptionAlgorithm.Rijndael:
                {
                    Rijndael rijndael = new RijndaelManaged();
                    rijndael.Mode = CipherMode.CBC;
                    // Test to see if a key was provided
                    if (null == bytesKey)
                    {
                        encKey = rijndael.Key;
                    }
                    else
                    {
                        rijndael.Key = bytesKey;
                        encKey = rijndael.Key;
                    }
                    // See if the client provided an IV
                    if (null == initVec)
                    { //Yes, have the alg create one
                        initVec = rijndael.IV;
                    }
                    else
                    { //No, give it to the alg.
                        rijndael.IV = initVec;
                    }
                    return rijndael.CreateEncryptor();
                }
                default:
                {
                    throw new CryptographicException("Algorithm ID '" + algorithmID + "' not supported.");
                }
            }
        }
    }

    public class DecryptTransformer
    {
        private EncryptionAlgorithm algorithmID;
        private byte[] initVec;

        internal DecryptTransformer(EncryptionAlgorithm deCryptId)
        {
            algorithmID = deCryptId;
        }

        internal byte[] IV
        {
            set { initVec = value; }
        }
        
        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            // Pick the provider.
            switch (algorithmID)
            {
                case EncryptionAlgorithm.Des:
                {
                    DES des = new DESCryptoServiceProvider();
                    des.Mode = CipherMode.CBC;
                    des.Key = bytesKey;
                    des.IV = initVec;
                    return des.CreateDecryptor();
                }
                case EncryptionAlgorithm.TripleDes:
                {
                    TripleDES des3 = new TripleDESCryptoServiceProvider();
                    des3.Mode = CipherMode.CBC;
                    return des3.CreateDecryptor(bytesKey, initVec);
                }
                case EncryptionAlgorithm.Rc2:
                {
                    RC2 rc2 = new RC2CryptoServiceProvider();
                    rc2.Mode = CipherMode.CBC;
                    return rc2.CreateDecryptor(bytesKey, initVec);
                }
                case EncryptionAlgorithm.Rijndael:
                {
                    Rijndael rijndael = new RijndaelManaged();
                    rijndael.Mode = CipherMode.CBC;
                    return rijndael.CreateDecryptor(bytesKey, initVec);
                }
                default:
                {
                    throw new CryptographicException("Algorithm ID '" + algorithmID +
                                                     "' not supported.");
                }
            }
        } //end GetCryptoServiceProvider
    }

    public class Encryptor
    {
        private EncryptTransformer transformer;
        private byte[] initVec;
        private byte[] encKey;
        
        public Encryptor(EncryptionAlgorithm algId)
        {
            transformer = new EncryptTransformer(algId);
        }

        public byte[] IV
        {
            get { return initVec; }
            set { initVec = value; }
        }

        public byte[] Key
        {
            get { return encKey; }
        }
        
        public byte[] Encrypt(byte[] bytesData, byte[] bytesKey)
        {
            //Set up the stream that will hold the encrypted data.
            MemoryStream memStreamEncryptedData = new MemoryStream();

            transformer.IV = initVec;
            ICryptoTransform transform = transformer.GetCryptoServiceProvider(bytesKey);
            CryptoStream encStream = new CryptoStream(memStreamEncryptedData,
                                                      transform,
                                                      CryptoStreamMode.Write);
            try
            {
                //Encrypt the data, write it to the memory stream.
                encStream.Write(bytesData, 0, bytesData.Length);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while writing encrypted data to the stream: \n"
                                    + ex.Message);
            }
            //Set the IV and key for the client to retrieve
            encKey = transformer.Key;
            initVec = transformer.IV;
            encStream.FlushFinalBlock();
            encStream.Close();

            //Send the data back.
            return memStreamEncryptedData.ToArray();
        }//end Encrypt
    }

    public class Decryptor
    {
        private DecryptTransformer transformer;
        private byte[] initVec;
        
        public Decryptor(EncryptionAlgorithm algId)
        {
            transformer = new DecryptTransformer(algId);
        }

        public byte[] IV
        {
            set { initVec = value; }
        }
        
        public byte[] Decrypt(byte[] bytesData, byte[] bytesKey)
        {
            //Set up the memory stream for the decrypted data.
            MemoryStream memStreamDecryptedData = new MemoryStream();

            //Pass in the initialization vector.
            transformer.IV = initVec;
            ICryptoTransform transform = transformer.GetCryptoServiceProvider(bytesKey);
            CryptoStream decStream = new CryptoStream(memStreamDecryptedData,
                                                      transform,
                                                      CryptoStreamMode.Write);
            try
            {
                decStream.Write(bytesData, 0, bytesData.Length);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while writing encrypted data to the stream: \n"
                                    + ex.Message);
            }
            decStream.FlushFinalBlock();
            decStream.Close();
            // Send the data back.
            return memStreamDecryptedData.ToArray();
        } //end Decrypt
    }

    public class SecurityHelper
    {
        public static string EncryptText(string text, string initkey)
        {
            // encrypt password
            byte[] IV = null;
            byte[] plainText = null;
            byte[] cipherText = null;
            byte[] key = null;
            try
            {
                // Create the encryptor.
                Encryptor enc = new Encryptor(EncryptionAlgorithm.TripleDes);
                plainText = Encoding.ASCII.GetBytes(text);
                // 3Des only work with a 16 or 24 byte key.
                // Des only works with an 8 byte key. 
                // The others uses variable length keys.
                // Set the key to null to have a new one generated. 
                key = Encoding.ASCII.GetBytes(initkey.PadRight(5, 'x').Substring(0, 5) + "57984354841");
                // Init vector must be 16 bytes for Rijndael.
                // The others uses variable length init vector.
                IV = Encoding.ASCII.GetBytes(initkey.PadRight(5, 'x').Substring(0, 5) + "789");
                enc.IV = IV;
                // Perform the encryption.
                cipherText = enc.Encrypt(plainText, key);
                /******************
                 * For debuging purpose only
                 * *****************
                // Look at your cipher text and initialization vector.
                Console.WriteLine("Cipher text: " + Encoding.ASCII.GetString(cipherText));
                Console.WriteLine("Init vector: " + Encoding.ASCII.GetString(IV));
                Console.WriteLine("        Key: " + Encoding.ASCII.GetString(key));
                Console.WriteLine(" Plain text: " + DecryptText(Convert.ToBase64String(cipherText), initkey));
                 ******************/
                // return encrypted password
                return Convert.ToBase64String(cipherText);
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                return null;
            }
        }

        public static string DecryptText(string text, string initkey)
        {
            // init vars
            byte[] IV = null;
            byte[] plainText = null;
            byte[] cipherText = null;
            byte[] key = null;
            //Try to decrypt.
            try
            {
                //Set up your decryption, give it the algorithm and initialization vector.
                Decryptor dec = new Decryptor(EncryptionAlgorithm.TripleDes);
                cipherText = Convert.FromBase64String(text);
                key = Encoding.ASCII.GetBytes(initkey.PadRight(5, 'x').Substring(0, 5) + "57984354841");
                IV = Encoding.ASCII.GetBytes(initkey.PadRight(5, 'x').Substring(0, 5) + "789");
                dec.IV = IV;
                // Go ahead and decrypt.
                plainText = dec.Decrypt(cipherText, key);
                // Look at your plain text.
                return Encoding.ASCII.GetString(plainText);
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                return null;
            }
        }
    }
}
