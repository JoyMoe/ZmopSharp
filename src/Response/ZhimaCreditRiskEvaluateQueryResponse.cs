using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditRiskEvaluateQueryResponse.
    /// </summary>
    public class ZhimaCreditRiskEvaluateQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 评估结果：true 通过，false 不通过
        /// </summary>
        [XmlElement("accessible")]
        public bool Accessible { get; set; }

        /// <summary>
        /// 拓展字段，存储明细信息，当前未开放
        /// </summary>
        [XmlElement("details")]
        public string Details { get; set; }

        /// <summary>
        /// 如果风险评估不通过，则输出对应不通过原因编码，具体编码请查看产品接口文档；
        /// </summary>
        [XmlElement("risk_code")]
        public string RiskCode { get; set; }
    }
}
