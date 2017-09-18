using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpContactNameGetResponse.
    /// </summary>
    public class ZhimaCreditEpContactNameGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业联系信息
        /// </summary>
        [XmlElement("company_contact")]
        public EpInfo CompanyContact { get; set; }
    }
}
