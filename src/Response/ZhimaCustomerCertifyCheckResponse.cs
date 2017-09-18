using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertifyCheckResponse.
    /// </summary>
    public class ZhimaCustomerCertifyCheckResponse : ZmopResponse
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
        /// 人脸照片。仅人脸核身时返回该属性
        /// </summary>
        [XmlElement("face_picture")]
        public string FacePicture { get; set; }

        /// <summary>
        /// ！！------废弃-----！！
        /// </summary>
        [XmlElement("identify_result")]
        public string IdentifyResult { get; set; }

        /// <summary>
        /// 用户身份识别返回的值为一个json串;例如: { authenticity=true, // 证件是否验证成功 birthday=1989年1月10日, //证件的生出生年月日 sex=男, // 证件上的性别 address=浙江省杭州市xx区xx街道xx号, // 证件上的住址 validity=2010.01.04-2020.01.04，//证件上的有效期 head_picture=/9j/4AAQS, // 证件上的头像字节码被base64加码后的字符串 cert_no=41302619890110
        /// </summary>
        [XmlElement("identity_result")]
        public string IdentityResult { get; set; }

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
