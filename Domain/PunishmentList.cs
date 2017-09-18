using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// PunishmentList Data Structure.
    /// </summary>
    [Serializable]
    public class PunishmentList : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("punishment_list")]
        [XmlArrayItem("punishment")]
        public List<Punishment> PunishmentList_ { get; set; }
    }
}
