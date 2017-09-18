using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditScoreCobuildGetResponse.
    /// </summary>
    public class ZhimaCreditScoreCobuildGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户共创风险评分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
