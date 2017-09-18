using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCloudatlasGetResponse.
    /// </summary>
    public class ZhimaCreditEpCloudatlasGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 云图编码
        /// </summary>
        [XmlElement("cloudatlas_code")]
        public string CloudatlasCode { get; set; }

        /// <summary>
        /// 边表列表，具体的字段内容含义参考产品说明文档
        /// </summary>
        [XmlArray("edges")]
        [XmlArrayItem("edge")]
        public List<Edge> Edges { get; set; }

        /// <summary>
        /// 点表列表,具体的字段内容含义参考产品说明文档
        /// </summary>
        [XmlArray("vertexs")]
        [XmlArrayItem("vertex")]
        public List<Vertex> Vertexs { get; set; }
    }
}
