using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditScoreIndustryGetResponse.
    /// </summary>
    public class ZhimaCreditScoreIndustryGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 行业分；
        /// </summary>
        [XmlElement("industry_score")]
        public string IndustryScore { get; set; }
    }
}
