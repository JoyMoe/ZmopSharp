using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditWatchlistiiGetResponse.
    /// </summary>
    public class ZhimaCreditWatchlistiiGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 行业关注名单信息列表，由芝麻信用进行维护和升级
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("zm_watch_list_detail")]
        public List<ZmWatchListDetail> Details { get; set; }

        /// <summary>
        /// true=命中 在关注名单中 false=未命中
        /// </summary>
        [XmlElement("is_matched")]
        public bool IsMatched { get; set; }
    }
}
