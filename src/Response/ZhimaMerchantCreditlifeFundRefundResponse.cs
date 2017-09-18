using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifeFundRefundResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifeFundRefundResponse : ZmopResponse
    {
        /// <summary>
        /// 资金流水号(支付宝)
        /// </summary>
        [XmlElement("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 退款交易是否成功
        /// </summary>
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 退款手续费(商家)
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款受理时间（格式:yyyy-MM-dd hh:mm:ss）
        /// </summary>
        [XmlElement("refund_pay_time")]
        public string RefundPayTime { get; set; }
    }
}
