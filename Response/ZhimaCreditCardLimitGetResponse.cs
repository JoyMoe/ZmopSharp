using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditCardLimitGetResponse.
    /// </summary>
    public class ZhimaCreditCardLimitGetResponse : ZmopResponse
    {
        /// <summary>
        /// 地址稳定性时长 5*365天及以上 - A  3*365天（含）~5*365天 - B  1*365天（含）~3*365天 - C  1*365天 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("address_stability")]
        public string AddressStability { get; set; }

        /// <summary>
        /// 支付宝账户活跃度 190及以上 - A  85~189 - B  30~84 - C  1~29 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("alipay_activity")]
        public string AlipayActivity { get; set; }

        /// <summary>
        /// 近1年支付宝活跃场景数 9个及以上 - A  6~8个 - B  3~5个 - C  1~2个 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("alipay_scene")]
        public string AlipayScene { get; set; }

        /// <summary>
        /// 活动区域稳定度 1个 - A  2个 - B  3个 - C  4个及以上 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("area_stability")]
        public string AreaStability { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 预测资产水平（还款能力） A 0 B (0，200] C (200,400] D (400,600] E (600,800] F (800,1000] G (1000,1500] H (1500,2000] I (2000,3000] J (3000,4000] K (4000,5000] L (5000,10000] M (10000,HIGH)? # 未知
        /// </summary>
        [XmlElement("capital_fund")]
        public string CapitalFund { get; set; }

        /// <summary>
        /// 消费档次 8及以上 - A  6（含）~8 - B  4（含）~6 - C  4以内 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("consume_level")]
        public string ConsumeLevel { get; set; }

        /// <summary>
        /// 高端类目交易客户 0 否 1 是 # 未知
        /// </summary>
        [XmlElement("consume_luxury")]
        public string ConsumeLuxury { get; set; }

        /// <summary>
        /// 预测月交易水平 A 0 B (0，200] C (200,400] D (400,600] E (600,800] F (800,1000] G (1000,1500] H (1500,2000] I (2000,3000] J (3000,4000] K (4000,5000] L (5000,10000] M (10000,HIGH) # 未知
        /// </summary>
        [XmlElement("consume_monthly")]
        public string ConsumeMonthly { get; set; }

        /// <summary>
        /// 预测笔均交易水平 A 0 B (0，100] C (100,200] D (200,400] E (400,600] F (600,800] G (800,1000] H (1000,1500] I (1500,2000] J (2000,HIGH] # 未知
        /// </summary>
        [XmlElement("consume_single")]
        public string ConsumeSingle { get; set; }

        /// <summary>
        /// 消费稳定度 0（不含）~0.5 - A  0.5（含）~1 - B  1（含）~2 - C  2及以上 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("consume_stability")]
        public string ConsumeStability { get; set; }

        /// <summary>
        /// 近1年人脉圈稳定度 80%及以上 - A 50%（含）~80% - B 20%（含）~50% - C 0%（含）~20% - D 缺失值 - #(2%)
        /// </summary>
        [XmlElement("contacts_stability")]
        public string ContactsStability { get; set; }

        /// <summary>
        /// 信用账户历史时长 3*365天及以上 - A  2*365天（含）~3*365天 - B  1*365天（含）~2*365天 - C  1*365天以内 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("credit_history")]
        public string CreditHistory { get; set; }

        /// <summary>
        /// 客户分群标识 1 无资金变动历史 and 注册时间小于3个月 2 无资金变动历史 and 注册时间大于等于3个月 3 有资金变动历史 and 近6个月无交易 4 有资金变动历史 and 注册时间小于3个月 and 近6个月交易次数小于3次 5 有资金变动历史 and 注册时间小于3个月 and 近6个月交易次数大于等于3次 6 有资金变动历史 and 注册时间大于等于3个月 and 近6个月交易次数小于6次 7 有资金变动历史 and 注册时间大于等于3个月小于6个月 and 近6个月交易次数大于等于6次 8 有资金变动历史 and 注册时间大于等于6个月 and 近6个月交易次数大于等于6次                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # 未知
        /// </summary>
        [XmlElement("cust_level")]
        public string CustLevel { get; set; }

        /// <summary>
        /// 是否法院老赖名单 是 - Y 否 - N 缺失值 - #
        /// </summary>
        [XmlElement("deadbeat")]
        public string Deadbeat { get; set; }

        /// <summary>
        /// 已履约的信用场景数 2个及以上 - A  1个 - B  缺失值或0 - #
        /// </summary>
        [XmlElement("honesty_scene")]
        public string HonestyScene { get; set; }

        /// <summary>
        /// 兴趣标签 如：宠物一族、花卉一族等 一个用户最多输出3个标签
        /// </summary>
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 最近一年使用手机号码数 1个 - A  2个 - B  3个 - C  4个及以上 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("mobile_count")]
        public string MobileCount { get; set; }

        /// <summary>
        /// 手机号稳定天数 5*365天及以上 - A  3*365天（含）~5*365天 - B  1*365天（含）~3*365天 - C  1*365天以内 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("mobile_stability")]
        public string MobileStability { get; set; }

        /// <summary>
        /// 生活缴费层次 500及以上 - A  300（含）~500 - B  100（含）~300 - C 0（不含）~100 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("pay_level")]
        public string PayLevel { get; set; }

        /// <summary>
        /// 社交影响力 30及以上 - A  20（含）~30 - B  10（含）~20 - C  0（不含）~10 - D  缺失值或0 - #
        /// </summary>
        [XmlElement("sns_influence")]
        public string SnsInfluence { get; set; }

        /// <summary>
        /// 行业信息清单
        /// </summary>
        [XmlArray("watch_list")]
        [XmlArrayItem("zm_watch_list_detail")]
        public List<ZmWatchListDetail> WatchList { get; set; }

        /// <summary>
        /// 用户芝麻信用分 350~950 从350到950之间的整数 # 未知
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
