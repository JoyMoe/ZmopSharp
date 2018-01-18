using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xunit;

namespace ZmopSharp.Core.Test
{
    public class ClientTests
    {
        [Fact]
        public void Client_Can_Be_Initialized()
        {
            var client = new Client
            {
                AppId = "000000000",
                AppKey = Constants.Encryption.PrivateKey,
                ZmopCert = Constants.Encryption.PublicKey
            };

            Assert.IsType<Client>(client);

            Assert.Equal("000000000", client.AppId);
        }

        [Fact]
        public void Client_Can_Get_Redirect_Uri()
        {
            var client = new Client
            {
                AppId = "000000000",
                AppKey = Constants.Encryption.PrivateKey,
                ZmopCert = Constants.Encryption.PublicKey
            };

            var request = new Request
            {
                AppId = "000000000",
                Method = "zhima.customer.certification.initialize",
                Params = "parameters",
                Sign = "signature"
            };

            Assert.StartsWith("https://zmopenapi.zmxy.com.cn/openapi.do", client.GetRedirectUri(request));
            Assert.Contains("app_id=000000000", client.GetRedirectUri(request));
            Assert.Contains("method=zhima.customer.certification.initialize", client.GetRedirectUri(request));
        }

        [Fact]
        public async Task Client_Can_Send_Request()
        {
            var client = new Client
            {
                AppId = "000000000",
                AppKey = Constants.Encryption.PrivateKey,
                ZmopCert = Constants.Encryption.PublicKey
            };

            var request = new Request
            {
                AppId = "000000000",
                Method = "zhima.customer.certification.initialize",
                Params = "parameters",
                Sign = "signature"
            };

            var result = await client.SendAsync(request);

            Assert.IsType<JObject>(result);
            Assert.Contains("ZMOP.invalid_appid_param", result.GetValue("biz_response").Value<string>());
        }
    }
}