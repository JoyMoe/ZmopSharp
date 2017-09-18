using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifeWithholdQueryResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifeWithholdQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 代扣签约产生的合约号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
