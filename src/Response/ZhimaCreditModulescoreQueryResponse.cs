using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditModulescoreQueryResponse.
    /// </summary>
    public class ZhimaCreditModulescoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 资产状况指数
        /// </summary>
        [XmlElement("asset_score")]
        public string AssetScore { get; set; }

        /// <summary>
        /// 行为表现指数
        /// </summary>
        [XmlElement("behavior_score")]
        public string BehaviorScore { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次调用的唯一标示，可用于后期对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 个人综合指数
        /// </summary>
        [XmlElement("composite_score")]
        public string CompositeScore { get; set; }

        /// <summary>
        /// 信用历史指数
        /// </summary>
        [XmlElement("credit_history_score")]
        public string CreditHistoryScore { get; set; }

        /// <summary>
        /// 身份特质指数
        /// </summary>
        [XmlElement("identity_score")]
        public string IdentityScore { get; set; }
    }
}
