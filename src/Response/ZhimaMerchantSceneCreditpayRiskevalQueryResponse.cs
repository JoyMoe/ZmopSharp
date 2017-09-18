using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantSceneCreditpayRiskevalQueryResponse.
    /// </summary>
    public class ZhimaMerchantSceneCreditpayRiskevalQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 0代表不在关注名单中，1代表在关注名单中
        /// </summary>
        [XmlElement("in_watch_list")]
        public string InWatchList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
