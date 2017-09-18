using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantSceneCreditpayBizriskevalQueryResponse.
    /// </summary>
    public class ZhimaMerchantSceneCreditpayBizriskevalQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻分
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
