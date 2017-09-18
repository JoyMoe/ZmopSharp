using System;
using System.Text;
using System.Security.Cryptography;
using System.Web;
using System.IO;
using System.ComponentModel;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System.Collections;
using Jayrock.Json.Conversion;
namespace Zmop.Api.Util
{
    /// <summary>
    /// RSA签名工具类。
    /// </summary>
    public class RSAUtil
    {
        /// <summary>
        /// 使用芝麻公钥进行加密
        /// </summary>
        /// <param name="data">需要加密的内容</param>
        /// <param name="publickey">芝麻公钥</param>
        /// <returns>加密后的密文</returns>
        public static string Encrypt(string data, string publickey, string charset)
        {
            byte[] dataInBytes = Encoding.GetEncoding(charset).GetBytes(data);
            byte[] btEncryptedSecret = Encrypt(dataInBytes, publickey);
            return Convert.ToBase64String(btEncryptedSecret);
        }

        /// <summary>
        /// 使用商户私钥进行解密
        /// </summary>
        /// <param name="data">商户公钥加密后的内容</param>
        /// <param name="publickey">芝麻公钥</param>
        /// <returns>解密后的明文</returns>
        public static string Decrypt(string data, string privateKey, String charset)
        {
            byte[] dataInBytes = Convert.FromBase64String(data);
            byte[] de = Decrypt(dataInBytes, privateKey);
            return Encoding.GetEncoding(charset).GetString(de);
        }

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="data"></param>
        /// <param name="privateKey"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string Sign(string data, string privateKey, string charset)
        {
            privateKey = ParseRSAPrivateKey(privateKey);
            RSACryptoServiceProvider rsaCsp = new RSACryptoServiceProvider();
            rsaCsp.FromXmlString(privateKey);


            byte[] dataBytes = null;
            if (string.IsNullOrEmpty(charset))
            {
                dataBytes = Encoding.GetEncoding(charset).GetBytes(data);
            }
            else
            {
                dataBytes = Encoding.GetEncoding(charset).GetBytes(data);
            }

            byte[] signatureBytes = rsaCsp.SignData(dataBytes, "SHA1");

            return Convert.ToBase64String(signatureBytes);
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="content">需要验证的内容</param>
        /// <param name="signedString">签名结果</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>验签结果</returns>
        public static bool Verify(string content, string signedString, string publicKey, string charset)
        {
            publicKey = ParseRSAPublicKey(publicKey);
            RSACryptoServiceProvider rsaPub = new RSACryptoServiceProvider();
            rsaPub.FromXmlString(publicKey);

            byte[] data = Encoding.GetEncoding(charset).GetBytes(content);
            byte[] signedData = Convert.FromBase64String(signedString);

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            bool result = rsaPub.VerifyData(data, sha1, signedData);
            return result;
        }

        private static byte[] Encrypt(byte[] dataInBytes, string publickey)
        {
            publickey = ParseRSAPublicKey(publickey);
            RSACryptoServiceProvider rsaSender = new RSACryptoServiceProvider();
            rsaSender.FromXmlString(publickey);


            int keySize = 0;
            int blockSize = 0;
            int lastblockSize = 0;
            int counter = 0;
            int iterations = 0;
            int index = 0;

            byte[] btPlaintextToken;
            byte[] btEncryptedToken;
            byte[] btEncryptedSecret;

            keySize = rsaSender.KeySize / 8;
            blockSize = keySize - 11;

            if ((dataInBytes.Length % blockSize) != 0)
            {
                iterations = dataInBytes.Length / blockSize + 1;
            }
            else
            {
                iterations = dataInBytes.Length / blockSize;
            }

            btPlaintextToken = new byte[blockSize];			//See REMARK 2 below.
            btEncryptedSecret = new byte[iterations * keySize];	//See REMARK 2 below.
            for (index = 0, counter = 0; counter < iterations; counter++, index += blockSize)
            {
                if (counter == (iterations - 1)) //last block
                {
                    //Size of last block to be encrypted.
                    lastblockSize = dataInBytes.Length % blockSize;
                    if (lastblockSize == 0)
                    {
                        lastblockSize = blockSize;
                    }

                    //REMARK 1: Caution! The last block of buffer may be of different size!
                    //		    Don't copy into a block which is larger than what's actually there in the last block. 
                    //		    - you won't get exception, but last block will not be decrypted properly.
                    btPlaintextToken = new byte[lastblockSize];
                    Array.Copy(dataInBytes, index, btPlaintextToken, 0, lastblockSize);
                }
                else
                {
                    Array.Copy(dataInBytes, index, btPlaintextToken, 0, blockSize);
                }

                //REMARK 2: Okay, here's the TRICK! (Again, you won't find this on MSDN!)
                //(a) Size of blocks going in: blockSize (btPlaintextToken going in)
                //(b) Size of blocks going out: keySize (btEncryptedToken coming out)
                //If you don't do this carefully, you get cryptographic exception: "Bad Data"
                btEncryptedToken = rsaSender.Encrypt(btPlaintextToken, false); //set fOAEP to true only if you have the high encryption pack.
                Array.Copy(btEncryptedToken, 0, btEncryptedSecret, counter * keySize, keySize);
            }

            return btEncryptedSecret;
        }

        public static byte[] Decrypt(byte[] dataInBytes, string privateKey)
        {
            privateKey = ParseRSAPrivateKey(privateKey);
            int keySize = 0;
            int blockSize = 0;
            int counter = 0;
            int iterations = 0;
            int index = 0;
            int byteCount = 0;

            byte[] btPlaintextToken;
            byte[] btEncryptedToken;
            byte[] btDecryptedSecret;

            RSACryptoServiceProvider rsaReceiver = new RSACryptoServiceProvider();
            rsaReceiver.FromXmlString(privateKey);
            keySize = rsaReceiver.KeySize / 8;
            blockSize = keySize - 11;

            //REMARK 3: This should always be true: "btEncryptedSecret.Length % keySize == 0"
           if ((dataInBytes.Length % keySize) != 0)
            {
                //Error condition.
                return null;
            }

            iterations = dataInBytes.Length / keySize;

            btEncryptedToken = new byte[keySize];	//See REMARK 4 below.
            Queue tokenQueue = new Queue();
            for (index = 0, counter = 0; counter < iterations; index += blockSize, counter++)
            {

                Array.Copy(dataInBytes, counter * keySize, btEncryptedToken, 0, keySize);

                //REMARK 4: Okay, here's another trick:
                //(a) Encrypted blocks going in: btEncryptedToken / size: keySize
                //(b) Decrypted plain text coming out: btPlaintextToken / size: blockSize
                btPlaintextToken = rsaReceiver.Decrypt(btEncryptedToken, false);
                tokenQueue.Enqueue(btPlaintextToken);
            }

            byteCount = 0;
            foreach (byte[] PlaintextToken in tokenQueue)
            {
                //REMARK 5: Size of decrypted buffer depends on size of last block.
                byteCount += PlaintextToken.Length;
            }

            counter = 0;
            btDecryptedSecret = new byte[byteCount]; //REMARK 5 (see foreach loop above)
            foreach (byte[] PlaintextToken in tokenQueue)
            {
                if (counter == (iterations - 1))
                {
                    Array.Copy(PlaintextToken, 0, btDecryptedSecret, btDecryptedSecret.Length - PlaintextToken.Length, PlaintextToken.Length);
                }
                else
                {
                    Array.Copy(PlaintextToken, 0, btDecryptedSecret, counter * blockSize, blockSize);
                }

                counter++;
            }

            return btDecryptedSecret;
        }

        /// <summary>
        /// 将公钥从String格式转化成.net能识别的xml格式
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static string ParseRSAPrivateKey(string privateKey)
        {
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));

            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
                Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
                Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));
        }

        public static string ParseRSAPublicKey(string publicKey)
        {
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
                Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
                Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));
        }

        /// <summary>
        /// 从开放平台返回的对象中，返回业务对象，如果需要解密的话就解密
        /// </summary>
        /// <param name="fullResponse"></param>
        /// <param name="privateKey"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string ParseBizResponse(string fullResponse, string privateKey, string charset) {
            IDictionary json = JsonConvert.Import(fullResponse) as IDictionary;
            if(json != null){
                string encryptedNode = json[ZhimaConstants.ENCRYPTED].ToString();

                bool encrypted = false;
                if(encryptedNode != null){
                    encrypted = bool.Parse(encryptedNode);
                }

                string bizResponse = null;
                foreach (object key in json.Keys){
                    string keyStr = key as string;
                    if(keyStr.EndsWith(ZhimaConstants.RESPONSE_SUFFIX)){
                        bizResponse = json[key] as string;
                        if (encrypted){
                            bizResponse = Decrypt(bizResponse, privateKey, charset);
                        }
                        break;
                    }
                }

                return bizResponse;
            }

            return null;
        }

        public static void VerifySign(string fullResponse, string decryptedBizRsp, string publicKey, string charset)
        {
            IDictionary json = JsonConvert.Import(fullResponse) as IDictionary;
            if (json != null)
            {
                string bizResponseSign = json[ZhimaConstants.BIZ_RESPONSE_SIGN] as string;
                if (bizResponseSign != null)
                {
                    bool verifyResult = Verify(decryptedBizRsp, bizResponseSign, publicKey, charset);
                    if (verifyResult == false)
                    {
                        throw new ZmopException("check sign failed: " + json.ToString());
                    }

                }
            }
        }
    }
}

