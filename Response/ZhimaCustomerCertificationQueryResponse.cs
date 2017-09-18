using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerCertificationQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 认证的主体属性信息
        /// </summary>
        [XmlElement("attribute_info")]
        public string AttributeInfo { get; set; }

        /// <summary>
        /// 认证过程中认证过的各渠道的状态，中间材料等数据
        /// </summary>
        [XmlElement("channel_statuses")]
        public string ChannelStatuses { get; set; }

        /// <summary>
        /// 认证没有通过的原因
        /// </summary>
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证的主体信息。如果初始化接口里面设置需要用户授权，这里就会返回OPEN_ID
        /// </summary>
        [XmlElement("identity_info")]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
