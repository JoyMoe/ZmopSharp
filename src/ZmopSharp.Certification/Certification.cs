using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ZmopSharp.Core;
using CertificationConstants = ZmopSharp.Constants.Certification;

namespace ZmopSharp
{
    public class Certification
    {
        private const string InitializationMethod = "zhima.customer.certification.initialize";
        private const string CertificationMethod = "zhima.customer.certification.certify";
        private const string QueryMethod = "zhima.customer.certification.query";
        private readonly Client _client;

        public Certification(Client client)
        {
            _client = client;
        }

        public Certification(string appId,string appKey, string zmopCert)
        {
            _client = new Client(appId, appKey, zmopCert);
        }

        public async Task<string> GetRedirectUriAsync(string transactionId, string bizCode, string identityParam, string returnUrl, string merchantConfig = "{\"need_user_authorization\": \"false\"}")
        {
            var result = await _client.SendAsync(new Request
            {
                Method = InitializationMethod,
                Params = new
                {
                    transaction_id = transactionId,
                    product_code = CertificationConstants.ProductCode.Certification,
                    biz_code = bizCode,
                    identity_param = identityParam,
                    merchant_config = merchantConfig,
                    ext_biz_param = "{}",
                },
            });

            return _client.GetRedirectUri(new Request
            {
                Method = CertificationMethod,
                Params = new
                {
                    biz_no = result["biz_response"]["biz_no"],
                    return_url = returnUrl,
                }
            });
        }

        public Task<JObject> QueryAsync(string bizNo)
        {
            return _client.SendAsync(new Request
            {
                Method = QueryMethod,
                Params = new
                {
                    biz_no = bizNo,
                },
            });
        }

        public JObject ParseResponse(string response, string signature)
        {
            return _client.ParseResponse(response, signature);
        }
    }
}