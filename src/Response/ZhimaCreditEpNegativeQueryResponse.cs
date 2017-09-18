using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpNegativeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpNegativeQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 负面信息
        /// </summary>
        [XmlElement("negative_info")]
        public AssetInfo NegativeInfo { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 翻页每页的条数
        /// </summary>
        [XmlElement("range")]
        public string Range { get; set; }

        /// <summary>
        /// 记录总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_num")]
        public string TotalPageNum { get; set; }
    }
}
