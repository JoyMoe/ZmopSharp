using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerEpCertificationQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 认证没有通过的原因
        /// </summary>
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
