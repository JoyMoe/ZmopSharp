using System.Net.Http;
using System.Collections.Generic;

namespace ZmopSharp.Core
{
    public class Request
    {
        public string AppId { get; set; }
        public string Charset { get; } = "UTF-8";
        public string Method { get; set; }
        public string Version { get; } = "1.0";
        public string Platform { get; } = "zmop";
        public object Params { get; set; }
        public string Sign { get; set; }

        public HttpContent ToHttpContent()
        {
            return new FormUrlEncodedContent(new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("app_id", AppId),
                new KeyValuePair<string, string>("charset", Charset),
                new KeyValuePair<string, string>("method", Method),
                new KeyValuePair<string, string>("version", Version),
                new KeyValuePair<string, string>("platform", Platform),
                new KeyValuePair<string, string>("params", Params as string),
                new KeyValuePair<string, string>("sign", Sign),
            });
        }
    }
}