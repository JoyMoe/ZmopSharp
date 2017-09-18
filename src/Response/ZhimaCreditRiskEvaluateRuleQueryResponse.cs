using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditRiskEvaluateRuleQueryResponse.
    /// </summary>
    public class ZhimaCreditRiskEvaluateRuleQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 对应规则配置信息列表
        /// </summary>
        [XmlArray("rule_infos")]
        [XmlArrayItem("risk_evaluate_rule_info")]
        public List<RiskEvaluateRuleInfo> RuleInfos { get; set; }
    }
}
