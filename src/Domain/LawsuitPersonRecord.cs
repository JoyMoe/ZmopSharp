using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// LawsuitPersonRecord Data Structure.
    /// </summary>
    [Serializable]
    public class LawsuitPersonRecord : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bgt_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> BgtList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("cpws_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> CpwsList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sxgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> SxggList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("wdhmd_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> WdhmdList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("zxgg_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> ZxggList { get; set; }
    }
}
