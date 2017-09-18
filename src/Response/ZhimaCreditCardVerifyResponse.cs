using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditCardVerifyResponse.
    /// </summary>
    public class ZhimaCreditCardVerifyResponse : ZmopResponse
    {
        /// <summary>
        /// [地址有效性评]通过用户申请时填写的邮寄地址和支付宝端地址信息进行匹配，快速判断该用户的邮寄信息是否可靠。将根据，收货地址与地址库的门址匹配，POI匹配，近期该地址使用，历史使用频率，使用时长，使用人数，物流触达等维度决定等级。 地址有效性定义主要考虑以下三方面原因综合来判断有效或可用程度： a.该地址是否能在地图上精准的描绘出经纬度 b.该地址是否为一个合法地址，包括前后包含关系是否合法等 c.地址的文本描述完整程度，包含的信息量是否丰富以及人能完整确定该地址等 共分为五个等级： 地址有效性定义主要考虑以下三方面原因综合来判断有效或可用程度： a.该地址是否能在地图上精准的描绘出经纬度 b.该地址是否为一个合法地址，包括前后包含关系是否合法等 c.地址的文本描述完整程度，包含的信息量是否丰富以及人能完整确定该地址等 共分为五个等级： 1：地址质量最高，上述三个方面角度都能比较好的反应该地址 2：地址质量较高，上述两个方面都能比较好的反应该地址另外一个方面稍差 3：地址质量一般，上述有两个方面能比较好的反应该地址 4：地址质量较差，上述只有一个方面能反应该地址其它两个角度都较差 5：地址质量最差，该地址基本不可理解和使用 总结：4、5级地址基本上不可用或者无效 1 地址质量最高，三个方面(见备注信息)角度都能比较好的反应该地址 2 地址质量较高，两个方面都能比较好的反应该地址另外一个方面稍差 3 地址质量一般，有两个方面能比较好的反应该地址 4 地址质量较差，只有一个方面能反应该地址其它两个角度都较差 5 地址质量最差，该地址基本不可理解和使用 # 未知
        /// </summary>
        [XmlElement("addr_score")]
        public string AddrScore { get; set; }

        /// <summary>
        /// [是否在校大学生学生]判断是否为在校大学生，主要原理为通过用户最近半年频繁使用的本人姓名收货地址和全国高校地址/校名/别名匹配后剔除年龄和特殊部门（如食堂，图书馆等）. 0 否 1 是 # 未知
        /// </summary>
        [XmlElement("be_student")]
        public string BeStudent { get; set; }

        /// <summary>
        /// [判断客户是否绑定过快捷]判断客户是否绑定过快捷. 1 绑定过信用卡快捷 2 无绑定信用卡快捷但绑定过借记卡快捷 3 其他  # 未知
        /// </summary>
        [XmlElement("bind_fast_payment")]
        public string BindFastPayment { get; set; }

        /// <summary>
        /// [是否类B客户]判断用户是否类B客户. 0 否 1 是 # 未知
        /// </summary>
        [XmlElement("biz_customer")]
        public string BizCustomer { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// [实名制类型]按用户是否绑定信用卡/借记卡快捷（含卡通）分为3档, (注：优先级顺序为信用卡快捷（含卡通）、借记卡快捷（含卡通）、其他实名方式). A100 信用卡快捷绑定 A080 借记卡快捷绑定 A060 其他实名制 # 未知
        /// </summary>
        [XmlElement("real_type")]
        public string RealType { get; set; }

        /// <summary>
        /// [注册时间]根据“注册时间”与“当前取数时间”的日期差分为4档，其中日期差不满30天的记为0个月，满30天算一个月。（向下取整）. 1 3月以下  2 4-6个月 3 7-12个月 4 12个月及以上 # 未知
        /// </summary>
        [XmlElement("regist_time")]
        public string RegistTime { get; set; }

        /// <summary>
        /// [是否活跃用户(动态一年淘宝实物交易等级) ]根据动态一年内客户有无创建或成功支付淘宝非炒信实物交易，分为4档. 1 无行为（无创建） 2 有行为无交易（有创建，无支付） 3 1-5次交易 4 6次及以上交易 # 未知
        /// </summary>
        [XmlElement("taobao_trade")]
        public string TaobaoTrade { get; set; }

        /// <summary>
        /// [在金融/理财类商户的交易信息]按动态一年内本人名字购买“淘宝理财、余额宝、定存宝、保险理财”总金额分为5档. D000 金额（元）=0元 D040 0<金额（元）<=1000 D060 1000<金额（元）<=3000 D080 3000<金额（元）<=5000 D100 金额（元）>5000 # 未知
        /// </summary>
        [XmlElement("trade_info_finance")]
        public string TradeInfoFinance { get; set; }

        /// <summary>
        /// [在生活类商户的交易信息]按动态一年内进行过本人“购买机票、信用卡还款、公共事业缴费、还贷款”等生活类实名制产品的操作次数分为5档. C000 0次 C040 1-2次 C060 3-5次 C080 6-10次 C100 10次以上 # 未知
        /// </summary>
        [XmlElement("trade_info_life")]
        public string TradeInfoLife { get; set; }

        /// <summary>
        /// [在实物类商户的交易信息]根据"最近一年首末次淘宝非炒信实物交易且为自己购买时间月份差(时间跨度)/最近一年淘宝非炒信实物交易且为本人购买次数/最近一年淘宝非炒信实物交易且为本人购买金额"三个指标，先对其做分档，然后再把分档值相乘得到一个综合值，再对这个综合值进行分档： 时间跨度 0：无交易，1：06个月以上； 交易次数 0：无交易，1：010次以上； 交易金额 0：无交易，1：01000元； E000 0 E020 1--10 E040 11--20 E060 21--35 E080 36--63 E100 64 # 未知
        /// </summary>
        [XmlElement("trade_info_material")]
        public string TradeInfoMaterial { get; set; }

        /// <summary>
        /// [核身综合评分]支付宝老人身份核身评分模型，用于判断一个客户身份在通过负面信息过滤后，从用户信息及交易行为做可行评分. 1 老用户，有银行验证且有实名场景高消费; 2 老用户，有银行验证且有实名场景中消费，或实名场景高消费 3 老用户，有银行验证且有实名场景低消费，或实名场景中消费 4 老用户，实名场景有低消费； 5 老用户，事务消费中，低； N_1 新用户，有银行验证且有实名场景高消费; N_2 新用户，银行验证且有实名场景中消费，或实名场景高消费； N_3 新用户，有银行验证且有实名场景低消费，或实名场景中消费； # 未知
        /// </summary>
        [XmlElement("verify_score")]
        public string VerifyScore { get; set; }
    }
}
