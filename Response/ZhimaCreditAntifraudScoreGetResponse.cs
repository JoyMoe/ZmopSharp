using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditAntifraudScoreGetResponse.
    /// </summary>
    public class ZhimaCreditAntifraudScoreGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 申请欺诈评分，分数范围是[0,100]的整数,分数越高信息越真实
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
