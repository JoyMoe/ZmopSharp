using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditKkcreditAcscoreQueryResponse.
    /// </summary>
    public class ZhimaCreditKkcreditAcscoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 用户的芝麻卡卡信用分。分值范围[393,784]。如果用户数据不足，无法评分时，返回数值0。
        /// </summary>
        [XmlElement("kkdac_score")]
        public long KkdacScore { get; set; }
    }
}
