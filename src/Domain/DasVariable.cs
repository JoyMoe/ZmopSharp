using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// DasVariable Data Structure.
    /// </summary>
    [Serializable]
    public class DasVariable : ZmopObject
    {
        /// <summary>
        /// 芝麻变量服务返回的变量名
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 芝麻变量服务返回的变量值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
