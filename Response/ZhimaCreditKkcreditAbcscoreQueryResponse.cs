using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditKkcreditAbcscoreQueryResponse.
    /// </summary>
    public class ZhimaCreditKkcreditAbcscoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 用户的芝麻卡卡信用分。分值范围[431,870]。如果用户数据不足，无法评分时，返回数值0。
        /// </summary>
        [XmlElement("kkdabc_score")]
        public long KkdabcScore { get; set; }
    }
}
