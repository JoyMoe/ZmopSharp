using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ZmopSharp.Core;
using ScoreConstants = ZmopSharp.Constants.Score;

namespace ZmopSharp.Score
{
    public class Score
    {
        private const string GetMethod = "zhima.credit.score.get";
        private readonly Client _client;

        public Score(Client client)
        {
            _client = client;
        }

        public Score(string appId,string appKey, string zmopCert)
        {
            _client = new Client(appId, appKey, zmopCert);
        }

        public async Task<int> GetAsync(string transactionId, string openId)
        {
            var result = await _client.SendAsync(new Request
            {
                Method = GetMethod,
                Params = new
                {
                    transaction_id = transactionId,
                    product_code = ScoreConstants.ProductCode.Score,
                    open_id = openId
                }
            });
            
            if (!result["biz_response"]["success"].Value<bool>())
            {
                throw new ZmopException(result["biz_response"]["errorMessage"].Value<string>());
            }

            return string.Equals("N/A", result["biz_response"]["zmScore"].Value<string>()) ? 0 : result["biz_response"]["zmScore"].Value<int>();
        }
    }
}