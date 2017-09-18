using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpTaxInvoiceQueryResponse.
    /// </summary>
    public class ZhimaCreditEpTaxInvoiceQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 无数据的原因 枚举值说明： EMPTY_RESULT  非航信企业 DATA_DISSATISFY_DEMAND 该企业数据不符合贵行的需求  REQUEST_LATER 请于T+3日再次访问
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 企业税务发票信息，数据说明见产品文档
        /// </summary>
        [XmlElement("tax_info")]
        public TaxInfo TaxInfo { get; set; }
    }
}
