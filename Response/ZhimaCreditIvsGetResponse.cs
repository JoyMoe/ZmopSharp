using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditIvsGetResponse.
    /// </summary>
    public class ZhimaCreditIvsGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// ivs评分。取值区间为[0,100]。分数越高，表示可信程度越高。0表示无对应数据。
        /// </summary>
        [XmlElement("ivs_score")]
        public long IvsScore { get; set; }
    }
}
