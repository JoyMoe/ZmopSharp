using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// ZmWatchListExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmWatchListExtendInfo : ZmopObject
    {
        /// <summary>
        /// 补充信息字段的中文描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 补充信息字段的英文编码
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 补充信息字段的信息内容
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
