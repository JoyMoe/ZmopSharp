using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPassinfoGetResponse.
    /// </summary>
    public class ZhimaCreditPassinfoGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 信息基础单元列表List<InfoItem>， 其中每个信息基础单元包含key,value, name三个属性
        /// </summary>
        [XmlArray("info_items")]
        [XmlArrayItem("info_item")]
        public List<InfoItem> InfoItems { get; set; }
    }
}
