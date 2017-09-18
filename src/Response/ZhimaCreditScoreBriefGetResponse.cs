using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditScoreBriefGetResponse.
    /// </summary>
    public class ZhimaCreditScoreBriefGetResponse : ZmopResponse
    {
        /// <summary>
        /// 准入判断结果  Y=准入,N=不准入,N/A=无法评估该用户的信用
        /// </summary>
        [XmlElement("is_admittance")]
        public string IsAdmittance { get; set; }
    }
}
