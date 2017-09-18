using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditSkynetriskGetResponse.
    /// </summary>
    public class ZhimaCreditSkynetriskGetResponse : ZmopResponse
    {
        /// <summary>
        /// 0-未命中； 1-低风； 2-中风险； 3-高风险
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }
    }
}
