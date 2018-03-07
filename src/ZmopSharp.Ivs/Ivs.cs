using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ZmopSharp.Core;
using ZmopSharp.Exceptions;
using IvsConstants = ZmopSharp.Constants.Ivs;

namespace ZmopSharp
{
    public class Ivs
    {
        private const string GetMethod = "zhima.credit.antifraud.score.get";
        private const string VerifyMethod = "zhima.credit.antifraud.verify";
        private const string ListMethod = "zhima.credit.antifraud.risk.list";
        private readonly Client _client;

        public Ivs(Client client)
        {
            _client = client;
        }

        public Ivs(string appId,string appKey, string zmopCert)
        {
            _client = new Client(appId, appKey, zmopCert);
        }
        
        public async Task<int> GetAsync(string transactionId, IvsParams param)
        {
            var result = await _client.SendAsync(new Request
            {
                Method = GetMethod,
                Params = param
            });

            if (!result["biz_response"]["success"].Value<bool>())
            {
                throw new ZmopException(result["biz_response"]["errorMessage"].Value<string>());
            }

            return result["biz_response"]["score"].Value<int>();
        }
        
        public async Task<IEnumerable<string>> VerifyAsync(string transactionId, IvsParams param)
        {
            var result = await _client.SendAsync(new Request
            {
                Method = VerifyMethod,
                Params = param
            });

            if (!result["biz_response"]["success"].Value<bool>())
            {
                throw new ZmopException(result["biz_response"]["errorMessage"].Value<string>());
            }

            return result["biz_response"]["verify_code"].Values<string>();
        }
        
        public async Task<IEnumerable<string>> ListAsync(string transactionId, IvsParams param)
        {
            var result = await _client.SendAsync(new Request
            {
                Method = ListMethod,
                Params = param
            });

            if (!result["biz_response"]["success"].Value<bool>())
            {
                throw new ZmopException(result["biz_response"]["errorMessage"].Value<string>());
            }

            return result["biz_response"]["risk_code"].Values<string>();
        }
    }
}