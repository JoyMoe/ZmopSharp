using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditContactAnalyzeQueryResponse.
    /// </summary>
    public class ZhimaCreditContactAnalyzeQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次调用的唯一标示，可用于后期对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务结果： 当有芝麻分用户数>=3时 返回true 并且返回均值 当有芝麻分用户数<3时 返回false 且不返回均值
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 关系人验证信息单元列表
        /// </summary>
        [XmlArray("contact_analyze_units")]
        [XmlArrayItem("contact_analyze_unit")]
        public List<ContactAnalyzeUnit> ContactAnalyzeUnits { get; set; }
    }
}
