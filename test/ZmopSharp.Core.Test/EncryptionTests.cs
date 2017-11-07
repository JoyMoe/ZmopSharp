using Xunit;

namespace ZmopSharp.Core.Test
{
    public class EncryptionTests
    {
        private const string PrivateKey = Constants.Encryption.PrivateKey;

        private const string PublicKey = Constants.Encryption.PublicKey;

        [Fact]
        public void Can_Encrypt_And_Decrypt()
        {
            const string plainText = "ZmopSharp";

            var cipher = Encryption.Encrypt(PublicKey, plainText);
            Assert.NotEmpty(cipher);

            var plain = Encryption.Decrypt(PrivateKey, cipher);
            Assert.NotEmpty(plain);

            Assert.Equal(plain, plainText);
        }

        [Fact]
        public void Can_Sign_And_Verify()
        {
            const string plainText = "ZmopSharp";

            var signature = Encryption.Sign(PrivateKey, plainText);
            Assert.NotEmpty(signature);

            var passed = Encryption.Verify(PublicKey, plainText, signature);
            Assert.True(passed);
        }
    }
}