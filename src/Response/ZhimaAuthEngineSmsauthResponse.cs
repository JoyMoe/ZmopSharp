using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaAuthEngineSmsauthResponse.
    /// </summary>
    public class ZhimaAuthEngineSmsauthResponse : ZmopResponse
    {
        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }

        /// <summary>
        /// 商户调用芝麻发短信的时候,芝麻发现用户已经授权就会直接返回,并且带openid参数
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户传递的透传数据,系统会重新回传给商户
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
