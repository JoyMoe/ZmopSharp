using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudIntegrationQueryResponse.
    /// </summary>
    public class ZhimaCreditAntifraudIntegrationQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 欺诈关注清单是否命中，yes标识命中，no标识未命中
        /// </summary>
        [XmlElement("hit_risk")]
        public string HitRisk { get; set; }

        /// <summary>
        /// 欺诈关注清单的RiskCode列表，对应的描述见产品文档
        /// </summary>
        [XmlArray("risk_code")]
        [XmlArrayItem("string")]
        public List<string> RiskCode { get; set; }

        /// <summary>
        /// 申请欺诈评分，分数范围是[0,100]的整数,分数越高信息越真实
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 欺诈信息验证，输出验证码verifyCode列表,verifyCode和文案的映射关系参见"产品接口说明"
        /// </summary>
        [XmlArray("verify_code")]
        [XmlArrayItem("string")]
        public List<string> VerifyCode { get; set; }
    }
}
