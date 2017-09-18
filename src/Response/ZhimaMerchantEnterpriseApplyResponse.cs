using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantEnterpriseApplyResponse.
    /// </summary>
    public class ZhimaMerchantEnterpriseApplyResponse : ZmopResponse
    {
        /// <summary>
        /// 二级商户标识
        /// </summary>
        [XmlElement("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
