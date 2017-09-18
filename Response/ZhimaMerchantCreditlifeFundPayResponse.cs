using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifeFundPayResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifeFundPayResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 支付处理结果(PAY_SUCCESS:支付成功,PAY_FAILED:支付处理失败,PAY_INPROGRESS:支付处理中)
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付处理时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }
    }
}
