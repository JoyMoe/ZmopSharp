using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// InfoItem Data Structure.
    /// </summary>
    [Serializable]
    public class InfoItem : ZmopObject
    {
        /// <summary>
        /// 键值对中对应的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 键值对中文描述
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 键值对中的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
