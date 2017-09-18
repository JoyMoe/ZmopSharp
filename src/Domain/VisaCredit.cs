using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// VisaCredit Data Structure.
    /// </summary>
    [Serializable]
    public class VisaCredit : ZmopObject
    {
        /// <summary>
        /// 银行
        /// </summary>
        [XmlElement("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// 英文信用卡等级
        /// </summary>
        [XmlElement("en_level")]
        public string EnLevel { get; set; }

        /// <summary>
        /// 信用卡等级
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 额度
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }
    }
}
