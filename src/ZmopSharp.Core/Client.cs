using System;
using System.Linq;
using System.Net;
using System.Net.Http;
#if NETSTANDARD1_3
using System.Reflection;
#endif
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ZmopSharp.Core
{
    public class Client
    {
        private const string Endpoint = "https://zmopenapi.zmxy.com.cn/openapi.do";

        private string _appKey;
        private string _zmopCert;

        public string AppId { get; set; }
        public string AppKey { set => _appKey = value; }
        public string ZmopCert { set => _zmopCert = value; }

        public Client()
        {
        }

        public Client(string appId,string appKey, string zmopCert)
        {
            AppId = appId;
            _appKey = appKey;
            _zmopCert = zmopCert;
        }

        public string GetRedirectUri(Request request)
        {
            request = PrepareRequest(request);

            return $"{Endpoint}?{request.ToHttpContent().ReadAsStringAsync().Result}";
        }

        public async Task<JObject> SendAsync(Request request)
        {
            request = PrepareRequest(request);

            using (var client = new HttpClient())
            {
                var message = await client.PostAsync(Endpoint, request.ToHttpContent());
                var result = await message.Content.ReadAsStringAsync();

                var jObject = JObject.Parse(result);

                if (jObject.GetValue("encrypted").Value<bool>())
                {
                    var response = jObject.GetValue("biz_response").Value<string>();
                    var signature = jObject.GetValue("biz_response_sign").Value<string>();

                    jObject["biz_response"] = JObject.Parse(ParseResponse(response, signature));
                    jObject["encrypted"] = false;
                }

                return jObject;
            }
        }

        public string ParseResponse(string response, string signature)
        {
            var plainText = Encryption.Decrypt(_appKey, response);

            if (!Encryption.Verify(_zmopCert, plainText, signature))
            {
                throw new Exception("Signature mismatch.");
            }

            return plainText;
        }

        private Request PrepareRequest(Request request)
        {
            if (string.IsNullOrEmpty(request.AppId))
            {
                if (string.IsNullOrEmpty(AppId))
                {
                    throw new ArgumentNullException(nameof(request.AppId));
                }

                request.AppId = AppId;
            }

            if (string.IsNullOrEmpty(request.Method))
            {
                throw new ArgumentNullException(nameof(request.Method));
            }

            if (request.Params == null)
            {
                throw new ArgumentNullException(nameof(request.Params));
            }

            var queryString = ObjectToQueryString(request.Params);

            request.Params = Encryption.Encrypt(_zmopCert, queryString);
            request.Sign = Encryption.Sign(_appKey, queryString);

            return request;
        }

        private static string ObjectToQueryString(object foo)
        {
            var properties = from p in foo.GetType().GetProperties()
                where p.GetValue(foo, null) != null
                select p.Name + "=" + WebUtility.UrlEncode(p.GetValue(foo, null).ToString());

            return string.Join("&", properties.ToArray());
        }
    }
}