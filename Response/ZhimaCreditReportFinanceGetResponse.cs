using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditReportFinanceGetResponse.
    /// </summary>
    public class ZhimaCreditReportFinanceGetResponse : ZmopResponse
    {
        /// <summary>
        /// 近1年常用收货地址数： 1个 - A  2个 - B  3个 - C  4个及以上 - D  缺失值 - N
        /// </summary>
        [XmlElement("address_count")]
        public string AddressCount { get; set; }

        /// <summary>
        /// 地址稳定性时长： A     5年及以上  B     3（含）~5年 C    1（含）~3年 D    1年以内  N    缺失值
        /// </summary>
        [XmlElement("address_stability")]
        public string AddressStability { get; set; }

        /// <summary>
        /// 反映最近1年的支付宝账号活跃情况： 190及以上 - A  85~189 - B  30~84 - C  1~29 - D  缺失值或0 - N
        /// </summary>
        [XmlElement("alipay_activity")]
        public string AlipayActivity { get; set; }

        /// <summary>
        /// 最近1年的支付宝平台的相关细分业务场景的活跃情况： 9个及以上 - A  6~8个 - B  3~5个 - C  1~2个 - D  缺失值或0 - N
        /// </summary>
        [XmlElement("alipay_scene")]
        public string AlipayScene { get; set; }

        /// <summary>
        /// 活动区域稳定性 1个 - A  2个 - B  3个 - C  4个及以上 - D  缺失值 - N
        /// </summary>
        [XmlElement("area_stability")]
        public string AreaStability { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 根据近1年的消费金额、类目、商品等推断整体消费档次并分层： 8及以上 - A  6（含）~8 - B  4（含）~6 - C  4以内 - D  缺失值 - N
        /// </summary>
        [XmlElement("consume_level")]
        public string ConsumeLevel { get; set; }

        /// <summary>
        /// 最近1年的月消费水平的持续性、稳定性水平： 0（不含）~0.5 - A  0.5（含）~1 - B  1（含）~2 - C  2及以上 - D
        /// </summary>
        [XmlElement("consume_stability")]
        public string ConsumeStability { get; set; }

        /// <summary>
        /// 和用户资金往来最密切的人群的平均芝麻信用评分: 700及以上 - A 650（含）~700 - B 600（含）~650 - C 550（含）~600 - D 550（不含）以下 - N
        /// </summary>
        [XmlElement("contacts_credit")]
        public string ContactsCredit { get; set; }

        /// <summary>
        /// 反映最近1年的用户人脉关系的变动情况: 80%及以上 - A 50%（含）~80% - B 20%（含）~50% - C 0%（含）~20% - D 缺失值 - N(2%)
        /// </summary>
        [XmlElement("contacts_stability")]
        public string ContactsStability { get; set; }

        /// <summary>
        /// 用户绑定信用卡账户的历史时长： 3年及以上 - A  2年（含）~3年 - B  1年（含）~2年 - C  1年以内 - D 缺失值 - N
        /// </summary>
        [XmlElement("credit_history")]
        public string CreditHistory { get; set; }

        /// <summary>
        /// 法院执行网公布的失信被执行人名单
        /// </summary>
        [XmlElement("deadbeat")]
        public bool Deadbeat { get; set; }

        /// <summary>
        /// 用户在具体的信用交易场景下，产生信用交易并完成正常履约。这些场景包括：免押金租车、信用贷款、消费分期、小额消费现金贷款等： 2个及以上 - A  1个 - B  缺失值 - N
        /// </summary>
        [XmlElement("honesty_scene")]
        public string HonestyScene { get; set; }

        /// <summary>
        /// 兴趣标签，如：宠物一族、花卉一族等
        /// </summary>
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 近1年曾用手机号码数： A    1个 B    2个 C    3个   D    4个及以上   N    缺失值
        /// </summary>
        [XmlElement("mobile_count")]
        public string MobileCount { get; set; }

        /// <summary>
        /// 手机稳定性： A     5年及以上  B     3（含）~5年 C     1（含）~3年 D     1年以内 N     缺失值
        /// </summary>
        [XmlElement("mobile_stability")]
        public string MobileStability { get; set; }

        /// <summary>
        /// 最近1年的月均水费、电费、煤气费等公用事业费的消费分层: 500及以上 - A  300（含）~500 - B  200（含）~300 - C  100（含）~200 - E  0（不含）~100 - D  缺失值或0 - N
        /// </summary>
        [XmlElement("pay_level")]
        public string PayLevel { get; set; }

        /// <summary>
        /// 用户是否发生过实名消费场景下的支付交易，如购买机票、预定酒店、购买彩票等
        /// </summary>
        [XmlElement("realname_consume")]
        public bool RealnameConsume { get; set; }

        /// <summary>
        /// 根据资金往来关系，按照影响力算法推断的用户的社会交往及社会关系的影响能力指数: 30及以上 - A  20（含）~30 - B  10（含）~20 - C  5（含）~10 - D  缺失值或0（含）~N
        /// </summary>
        [XmlElement("sns_influence")]
        public string SnsInfluence { get; set; }
    }
}
