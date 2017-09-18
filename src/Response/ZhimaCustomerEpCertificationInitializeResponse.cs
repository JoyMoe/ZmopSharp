using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerEpCertificationInitializeResponse.
    /// </summary>
    public class ZhimaCustomerEpCertificationInitializeResponse : ZmopResponse
    {
        /// <summary>
        /// 本次认证的唯一标识，商户需要记录，biz_no有效期为23小时
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
