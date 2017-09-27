using System;
using Xunit;

namespace ZmopSharp.Core.Test
{
    public class EncryptionTests
    {
        private static readonly string _privateKey = @"MIICXAIBAAKBgQDRNHK6ljEQmuVjnNGYO3DXsIJdi4QYJ4y5fgGh7D/Mbh2e463A
k35uNkIktHH+NNGAK3UQg3MWOPU3UEUOWZlD+inRHBI4ZVrAMaFT9JlxuAblxZbb
Xnl4pJsZHgYVPyQrn9L7B8o+Sovs8IzIgK9fklHl880oyQ6/uxrEoQHaGwIDAQAB
AoGATixEBrbipKrMtpk9tJ3Zf69kN2JPvNriedm88G2gNVqcVOgM4B39K1+4/ZAz
3GKOOk+C0eXcllw4PTAQbdlLLG+RgQwd8Q6+Iz+S1jAQZxVUpRUF630TTgfqHSgQ
nDBe7vhS/hFHDkxMHk4yBpWSaLdjJ1+lq8qirIb+Gu3woeECQQDqgJxjXrMdcPZP
hef67WDkzIU1fcPW9+dm178LdQ3zFVF0i7sSsv4L1oTn89JP2AJReMGSFpejTo9q
4PIWTBqLAkEA5GIlWRzsViYrSye6bl7qg+MzH838xJl79zsLsGNX4nmB6py/D47o
e5DH5qP4wZKLc0HWkQ6v1hQT515xRRqAsQJAdY6f15jjxgCZGeiRENPrXQfCR7yS
brO8R2wkk8PMiG3JddmOoKMmhBy4Z+dtKSWqk9krgObegbmiX/wAoHjqXQJBAKdI
zJqNeP9RTfzqyL/3fkfEr7noI/HNiuP4uAMngUQ+RE8ZKUm4H8oCrqneCWOgd8yg
uQ3feCSS6FFc+BLp6sECQFGT4iZGvdYa2JfDVM2fhIylQmHPuaFROfRZziE/55Gc
e4DiFgSSCe9mkGyLxyi1/uarK7GtAu0/V5uhw3GGPfg=".Replace("\n", "");
        
        private static readonly string _publicKey = @"MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDRNHK6ljEQmuVjnNGYO3DXsIJd
i4QYJ4y5fgGh7D/Mbh2e463Ak35uNkIktHH+NNGAK3UQg3MWOPU3UEUOWZlD+inR
HBI4ZVrAMaFT9JlxuAblxZbbXnl4pJsZHgYVPyQrn9L7B8o+Sovs8IzIgK9fklHl
880oyQ6/uxrEoQHaGwIDAQAB".Replace("\n", "");
        
        [Fact]
        public void Can_Encrypt_And_Decrypt()
        {
            const string plainText = "ZmopSharp";

            var cipher = Encryption.Encrypt(_publicKey, plainText);
            Assert.NotEmpty(cipher);
            
            var plain = Encryption.Decrypt(_privateKey, cipher);
            Assert.NotEmpty(plain);
            
            Assert.Equal(plain, plainText);
        }

        [Fact]
        public void Can_Sign_And_Verify()
        {
            const string plainText = "ZmopSharp";

            var signature = Encryption.Sign(_privateKey, plainText);
            Assert.NotEmpty(signature);
            
            var passed = Encryption.Verify(_publicKey, plainText, signature);
            Assert.True(passed);
        }
    }
}