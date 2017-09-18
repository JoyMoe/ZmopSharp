using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantSceneCreditpaySignriskevalQueryResponse.
    /// </summary>
    public class ZhimaMerchantSceneCreditpaySignriskevalQueryResponse : ZmopResponse
    {
        /// <summary>
        /// openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 芝麻分
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
