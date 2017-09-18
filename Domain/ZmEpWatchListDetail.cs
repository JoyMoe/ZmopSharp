using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// ZmEpWatchListDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZmEpWatchListDetail : ZmopObject
    {
        /// <summary>
        /// 风险信息行业编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 风险编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 企业名称，可能为空
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("extend_info")]
        [XmlArrayItem("zm_watch_list_extend_info")]
        public List<ZmWatchListExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 数据刷新时间
        /// </summary>
        [XmlElement("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 当企业进行异议处理，并核查完毕之后，仍有异议时，给出的声明
        /// </summary>
        [XmlElement("statement")]
        public string Statement { get; set; }

        /// <summary>
        /// 用户本人对该条负面记录有异议时，表示该异议处理流程的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 行业名单风险类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
