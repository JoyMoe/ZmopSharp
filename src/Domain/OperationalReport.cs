using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// OperationalReport Data Structure.
    /// </summary>
    [Serializable]
    public class OperationalReport : ZmopObject
    {
        /// <summary>
        /// 经营报告中的key值，详细值见产品说明文档
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 企业征信报告经营数据具体字段的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
