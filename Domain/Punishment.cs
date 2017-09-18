using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// Punishment Data Structure.
    /// </summary>
    [Serializable]
    public class Punishment : ZmopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("punishment")]
        [XmlArrayItem("ep_element")]
        public List<EpElement> Punishment_ { get; set; }
    }
}
