using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRiskIndexGetResponse.
    /// </summary>
    public class ZhimaCreditEpRiskIndexGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 风险指数
        /// </summary>
        [XmlArray("risk_index")]
        [XmlArrayItem("risk_index")]
        public List<RiskIndex> RiskIndex { get; set; }
    }
}
