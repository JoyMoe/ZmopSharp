using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// EpElement Data Structure.
    /// </summary>
    [Serializable]
    public class EpElement : ZmopObject
    {
        /// <summary>
        /// key键值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// value键值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
