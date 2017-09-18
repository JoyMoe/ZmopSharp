using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifePreauthCancelResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifePreauthCancelResponse : ZmopResponse
    {
        /// <summary>
        /// 显示入参的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
