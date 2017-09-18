using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditKkcreditAbscoreQueryResponse.
    /// </summary>
    public class ZhimaCreditKkcreditAbscoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 用户的芝麻卡卡信用分。分值范围[429,832]。如果用户数据不足，无法评分时，返回数值0。
        /// </summary>
        [XmlElement("kkdab_score")]
        public long KkdabScore { get; set; }
    }
}
