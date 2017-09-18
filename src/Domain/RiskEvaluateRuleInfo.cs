using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// RiskEvaluateRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskEvaluateRuleInfo : ZmopObject
    {
        /// <summary>
        /// 规则是否可降级
        /// </summary>
        [XmlElement("demote")]
        public string Demote { get; set; }

        /// <summary>
        /// 规则描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 规则约束值
        /// </summary>
        [XmlElement("expect_value")]
        public string ExpectValue { get; set; }

        /// <summary>
        /// 规则对应逻辑符
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 整数值，标示规则在策略中顺序
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 规则不通过时对应的风险编码
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }
    }
}
