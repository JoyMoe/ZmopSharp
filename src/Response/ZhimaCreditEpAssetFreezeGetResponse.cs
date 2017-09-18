using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssetFreezeGetResponse.
    /// </summary>
    public class ZhimaCreditEpAssetFreezeGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 资产冻结信息
        /// </summary>
        [XmlElement("user_asset_freeze_info")]
        public AssetInfo UserAssetFreezeInfo { get; set; }
    }
}
