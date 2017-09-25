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
            var cipherBytes = rsa.Encrypt(Encoding.UTF8.GetBytes(data), RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(cipherBytes);
        }

        public static string Sign(string appKey, string data)
        {
            var rsa = CreateFromPrivateKey(appKey);
            var signatureBytes = rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            return Convert.ToBase64String(signatureBytes);
        }

        public static string Decrypt(string appKey, string data)
        {
            var rsa = CreateFromPrivateKey(appKey);
            return Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(data), RSAEncryptionPadding.Pkcs1));
        }

        public static bool Verify(string zmopCert, string data, string signature)
        {
            var rsa = CreateFromPublicKey(zmopCert);
            return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(signature), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
        }

        private static RSA CreateFromPrivateKey(string privateKey)
        {
            var privateKeyBits = Convert.FromBase64String(privateKey);
            var rsa = RSA.Create();
            var rsAparams = new RSAParameters();

            using (var binr = new BinaryReader(new MemoryStream(privateKeyBits)))
            {
                byte bt;
                ushort twobytes;
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
                        throw new Exception("Unexpected value read binr.ReadUInt16()");
                }

                twobytes = binr.ReadUInt16();
                if (twobytes != 0x0102)
                    throw new Exception("Unexpected version");

                bt = binr.ReadByte();
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
            byte bt;
            int count;
            bt = binr.ReadByte();
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

        private static RSA CreateFromPublicKey(string publicKeyString)
        {
            byte[] seqOid = { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };
            byte[] seq;

            var x509Key = Convert.FromBase64String(publicKeyString);

            using (var mem = new MemoryStream(x509Key))
            {
                using (var binr = new BinaryReader(mem))
                {
                    byte bt;
                    ushort twobytes;

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

                    seq = binr.ReadBytes(15);
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

                    bt = binr.ReadByte();
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

                    var rsa = RSA.Create();
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