using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerBorrowRestoreResponse.
    /// </summary>
    public class ZhimaCustomerBorrowRestoreResponse : ZmopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
