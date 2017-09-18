using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertifyApplyResponse.
    /// </summary>
    public class ZhimaCustomerCertifyApplyResponse : ZmopResponse
    {
        /// <summary>
        /// 认证返回结果码，certify_result为false时有值
        /// </summary>
        [XmlElement("certify_errorcode")]
        public string CertifyErrorcode { get; set; }

        /// <summary>
        /// 认证错误信息
        /// </summary>
        [XmlElement("certify_errormessage")]
        public string CertifyErrormessage { get; set; }

        /// <summary>
        /// 认证结果标识，成功为true，失败为false
        /// </summary>
        [XmlElement("certify_result")]
        public string CertifyResult { get; set; }

        /// <summary>
        /// 芝麻会员在商户端的身份标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 实名标识（T：实名，F：非实名）
        /// </summary>
        [XmlElement("real_name_flag")]
        public string RealNameFlag { get; set; }

        /// <summary>
        /// 为商户自助传递的参数,芝麻不做任何的业务处理，透传给商户。商户端可以使用改属性传递用户唯一标识，在回调中识别用户
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 芝麻认证每一次请求返回的令牌，发起页面认证请求和认证请求结果查询接口都需要使用到该返回值作为入参
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
