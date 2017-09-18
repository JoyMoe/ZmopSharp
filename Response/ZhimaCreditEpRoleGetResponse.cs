using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRoleGetResponse.
    /// </summary>
    public class ZhimaCreditEpRoleGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业个人工商信息
        /// </summary>
        [XmlElement("company_role")]
        public CompanyRole CompanyRole { get; set; }
    }
}
