using System;
using System.Xml.Serialization;

namespace Zmop.Api.Domain
{
    /// <summary>
    /// CreditRecordMonthlyCount Data Structure.
    /// </summary>
    [Serializable]
    public class CreditRecordMonthlyCount : ZmopObject
    {
        /// <summary>
        /// 信用业务场景
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlElement("biz_scene_name")]
        public string BizSceneName { get; set; }

        /// <summary>
        /// 信用记录次数
        /// </summary>
        [XmlElement("credit_record_count")]
        public long CreditRecordCount { get; set; }
    }
}
