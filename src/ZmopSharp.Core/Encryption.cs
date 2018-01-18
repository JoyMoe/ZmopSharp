using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ZmopSharp.Core
{
    public static class Encryption
    {
        public static string Encrypt(string zmopCert, string data)
        {
            var rsa = CreateFromPublicKey(zmopCert);

            var plainBytes = Encoding.UTF8.GetBytes(data);
            var maxBlockSize = rsa.KeySize / 8 - 11;
            if (plainBytes.Length <= maxBlockSize)
            {
#if NET452
                return Convert.ToBase64String(rsa.Encrypt(plainBytes, false));
#else
                return Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(data), RSAEncryptionPadding.Pkcs1));
#endif
            }
            using (var plainStream = new MemoryStream(plainBytes))
            using (var cipherStream = new MemoryStream())
            {
                var buffer = new byte[maxBlockSize];
                var blockSize = plainStream.Read(buffer, 0, maxBlockSize);

                while (blockSize > 0)
                {
                    var toEncrypt = new byte[blockSize];
                    Array.Copy(buffer, 0, toEncrypt, 0, blockSize);

#if NET452
                    var cryptograph = rsa.Encrypt(toEncrypt, false);
#else
                    var cryptograph = rsa.Encrypt(toEncrypt, RSAEncryptionPadding.Pkcs1);
#endif

                    cipherStream.Write(cryptograph, 0, cryptograph.Length);

                    blockSize = plainStream.Read(buffer, 0, maxBlockSize);
                }

                return Convert.ToBase64String(cipherStream.ToArray());
            }
        }

        public static string Sign(string appKey, string data)
        {
            var rsa = CreateFromPrivateKey(appKey);
#if NET452
            var signatureBytes = rsa.SignData(Encoding.UTF8.GetBytes(data), new SHA1CryptoServiceProvider());
#else
            var signatureBytes = rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
#endif
            return Convert.ToBase64String(signatureBytes);
        }

        public static string Decrypt(string appKey, string data)
        {
            var rsa = CreateFromPrivateKey(appKey);

            var cipherBytes = Convert.FromBase64String(data);
            var maxBlockSize = rsa.KeySize / 8;
            if (cipherBytes.Length <= maxBlockSize)
            {
#if NET452
                return Encoding.UTF8.GetString(rsa.Decrypt(cipherBytes, false));
#else
                return Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(data), RSAEncryptionPadding.Pkcs1));
#endif
            }
            using (var cipherStream = new MemoryStream(cipherBytes))
            using (var plainStream = new MemoryStream())
            {
                var buffer = new byte[maxBlockSize];
                var blockSize = cipherStream.Read(buffer, 0, maxBlockSize);

                while (blockSize > 0)
                {
                    var toDecrypt = new byte[blockSize];
                    Array.Copy(buffer, 0, toDecrypt, 0, blockSize);

#if NET452
                    var plaintext = rsa.Decrypt(toDecrypt, false);
#else
                    var plaintext = rsa.Decrypt(Convert.FromBase64String(data), RSAEncryptionPadding.Pkcs1);
#endif

                    plainStream.Write(plaintext, 0, plaintext.Length);

                    blockSize = cipherStream.Read(buffer, 0, maxBlockSize);
                }

                return Encoding.UTF8.GetString(plainStream.ToArray());
            }
        }

        public static bool Verify(string zmopCert, string data, string signature)
        {
            var rsa = CreateFromPublicKey(zmopCert);
#if NET452
            return rsa.VerifyData(Encoding.UTF8.GetBytes(data), new SHA1CryptoServiceProvider(), Convert.FromBase64String(signature));
#else
            return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(signature), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
#endif
        }

#if NET452
        private static RSACryptoServiceProvider CreateFromPrivateKey(string privateKey)
#else
        private static RSA CreateFromPrivateKey(string privateKey)
#endif
        {
            var privateKeyBits = Convert.FromBase64String(privateKey);

#if NET452
            var rsa = new RSACryptoServiceProvider();
#else
            var rsa = RSA.Create();
#endif

            var rsAparams = new RSAParameters();

            using (var binr = new BinaryReader(new MemoryStream(privateKeyBits)))
            {
                var twobytes = binr.ReadUInt16();
                switch (twobytes)
                {
                    case 0x8130:
                        binr.ReadByte();
                        break;
                    case 0x8230:
                        binr.ReadInt16();
                        break;
                    default:
                        throw new Exception("Unexpected value read binr.ReadUInt16()");
                }

                twobytes = binr.ReadUInt16();
                if (twobytes != 0x0102)
                    throw new Exception("Unexpected version");

                var bt = binr.ReadByte();
                if (bt != 0x00)
                    throw new Exception("Unexpected value read binr.ReadByte()");

                rsAparams.Modulus = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.Exponent = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.D = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.P = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.Q = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.DP = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.DQ = binr.ReadBytes(GetIntegerSize(binr));
                rsAparams.InverseQ = binr.ReadBytes(GetIntegerSize(binr));
            }

            rsa.ImportParameters(rsAparams);
            return rsa;
        }

        private static int GetIntegerSize(BinaryReader binr)
        {
            int count;
            var bt = binr.ReadByte();
            if (bt != 0x02)
                return 0;
            bt = binr.ReadByte();

            switch (bt)
            {
                case 0x81:
                    count = binr.ReadByte();
                    break;
                case 0x82:
                    var highbyte = binr.ReadByte();
                    var lowbyte = binr.ReadByte();
                    byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                    count = BitConverter.ToInt32(modint, 0);
                    break;
                default:
                    count = bt;
                    break;
            }

            while (binr.ReadByte() == 0x00)
            {
                count -= 1;
            }
            binr.BaseStream.Seek(-1, SeekOrigin.Current);
            return count;
        }

#if NET452
        private static RSACryptoServiceProvider CreateFromPublicKey(string publicKeyString)
#else
        private static RSA CreateFromPublicKey(string publicKeyString)
#endif
        {
            byte[] seqOid = { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };

            var x509Key = Convert.FromBase64String(publicKeyString);

            using (var mem = new MemoryStream(x509Key))
            {
                using (var binr = new BinaryReader(mem))
                {
                    var twobytes = binr.ReadUInt16();
                    switch (twobytes)
                    {
                        case 0x8130:
                            binr.ReadByte();
                            break;
                        case 0x8230:
                            binr.ReadInt16();
                            break;
                        default:
                            return null;
                    }

                    var seq = binr.ReadBytes(15);
                    if (!CompareBytearrays(seq, seqOid))
                        return null;

                    twobytes = binr.ReadUInt16();
                    switch (twobytes)
                    {
                        case 0x8103:
                            binr.ReadByte();
                            break;
                        case 0x8203:
                            binr.ReadInt16();
                            break;
                        default:
                            return null;
                    }

                    var bt = binr.ReadByte();
                    if (bt != 0x00)
                        return null;

                    twobytes = binr.ReadUInt16();
                    switch (twobytes)
                    {
                        case 0x8130:
                            binr.ReadByte();
                            break;
                        case 0x8230:
                            binr.ReadInt16();
                            break;
                        default:
                            return null;
                    }

                    twobytes = binr.ReadUInt16();
                    byte lowbyte;
                    byte highbyte = 0x00;

                    switch (twobytes)
                    {
                        case 0x8102:
                            lowbyte = binr.ReadByte();
                            break;
                        case 0x8202:
                            highbyte = binr.ReadByte();
                            lowbyte = binr.ReadByte();
                            break;
                        default:
                            return null;
                    }
                    byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                    var modsize = BitConverter.ToInt32(modint, 0);

                    var firstbyte = binr.PeekChar();
                    if (firstbyte == 0x00)
                    {
                        binr.ReadByte();
                        modsize -= 1;
                    }

                    var modulus = binr.ReadBytes(modsize);

                    if (binr.ReadByte() != 0x02)
                        return null;
                    var expbytes = (int)binr.ReadByte();
                    var exponent = binr.ReadBytes(expbytes);

#if NET452
                    var rsa = new RSACryptoServiceProvider();
#else
                    var rsa = RSA.Create();
#endif

                    var rsaKeyInfo = new RSAParameters
                    {
                        Modulus = modulus,
                        Exponent = exponent
                    };
                    rsa.ImportParameters(rsaKeyInfo);
                    return rsa;
                }

            }
        }

        private static bool CompareBytearrays(IReadOnlyCollection<byte> a, IReadOnlyList<byte> b)
        {
            if (a.Count != b.Count)
                return false;
            var i = 0;
            foreach (var c in a)
            {
                if (c != b[i])
                    return false;
                i++;
            }
            return true;
        }
    }
}