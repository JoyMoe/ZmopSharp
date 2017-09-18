using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// LawsuitRecord Data Structure.
    /// </summary>
    [Serializable]
    public class LawsuitRecord : ZmopObject
    {
        /// <summary>
        /// （企业涉诉）案件流程
        /// </summary>
        [XmlArray("ajlc_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> AjlcList { get; set; }

        /// <summary>
        /// （企业涉诉）曝光台
        /// </summary>
        [XmlArray("bgt_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> BgtList { get; set; }

        /// <summary>
        /// （企业涉诉）裁判文书
        /// </summary>
        [XmlArray("cpws_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> CpwsList { get; set; }

        /// <summary>
        /// （企业涉诉）法院公告
        /// </summary>
        [XmlArray("fygg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> FyggList { get; set; }

        /// <summary>
        /// （企业涉诉）开庭公告
        /// </summary>
        [XmlArray("ktgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> KtggList { get; set; }

        /// <summary>
        /// （企业涉诉）失信公告
        /// </summary>
        [XmlArray("sxgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> SxggList { get; set; }

        /// <summary>
        /// （企业涉诉）执行公告
        /// </summary>
        [XmlArray("zxgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> ZxggList { get; set; }
    }
}
