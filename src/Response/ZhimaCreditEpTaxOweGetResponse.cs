using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpTaxOweGetResponse.
    /// </summary>
    public class ZhimaCreditEpTaxOweGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 欠税信息
        /// </summary>
        [XmlElement("user_tax_owe_info")]
        public TaxOweList UserTaxOweInfo { get; set; }
    }
}
