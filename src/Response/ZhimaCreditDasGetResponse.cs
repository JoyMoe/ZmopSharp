using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditDasGetResponse.
    /// </summary>
    public class ZhimaCreditDasGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 芝麻信用元素表服务返回的元素列表, 即为签约时选择的变量列表。
        /// </summary>
        [XmlArray("vars")]
        [XmlArrayItem("das_variable")]
        public List<DasVariable> Vars { get; set; }
    }
}
