using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// MonthRiskIndex Data Structure.
    /// </summary>
    [Serializable]
    public class MonthRiskIndex : ZmopObject
    {
        /// <summary>
        /// 月份，格式为yyyyMM
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 风险指数，整数
        /// </summary>
        [XmlElement("risk_index")]
        public long RiskIndex { get; set; }
    }
}
