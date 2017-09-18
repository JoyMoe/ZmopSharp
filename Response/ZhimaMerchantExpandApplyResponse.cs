using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantExpandApplyResponse.
    /// </summary>
    public class ZhimaMerchantExpandApplyResponse : ZmopResponse
    {
        /// <summary>
        /// 二级商户标识
        /// </summary>
        [XmlElement("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }
    }
}
