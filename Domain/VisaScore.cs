using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// VisaScore Data Structure.
    /// </summary>
    [Serializable]
    public class VisaScore : ZmopObject
    {
        /// <summary>
        /// 英文等级
        /// </summary>
        [XmlElement("en_level")]
        public string EnLevel { get; set; }

        /// <summary>
        /// 评估日期
        /// </summary>
        [XmlElement("eval_date")]
        public string EvalDate { get; set; }

        /// <summary>
        /// 信用等级
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 芝麻信用评分
        /// </summary>
        [XmlElement("zm_score")]
        public long ZmScore { get; set; }
    }
}
