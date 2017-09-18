using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// AssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetInfo : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("ep_info")]
        public List<EpInfo> AssetList { get; set; }
    }
}
