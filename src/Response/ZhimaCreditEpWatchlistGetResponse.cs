using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpWatchlistGetResponse.
    /// </summary>
    public class ZhimaCreditEpWatchlistGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业关注名单的详细信息
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("zm_ep_watch_list_detail")]
        public List<ZmEpWatchListDetail> Details { get; set; }

        /// <summary>
        /// true=命中 在关注名单中 false=未命中
        /// </summary>
        [XmlElement("is_matched")]
        public bool IsMatched { get; set; }
    }
}
