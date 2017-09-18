using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.msxf.onlinejdscore.query
    /// </summary>
    public class ZhimaCreditMsxfOnlinejdscoreQueryRequest : IZmopRequest<ZhimaCreditMsxfOnlinejdscoreQueryResponse>
    {
        /// <summary>
        /// 特殊订单金额差异占比
        /// </summary>
        public string AllFddifDivideSixaQdHourbinAmtaorder { get; set; }

        /// <summary>
        /// 短时间下单金额的差异系数
        /// </summary>
        public string AllFddifMinusFiveaRangeHourbinAmtaorder { get; set; }

        /// <summary>
        /// 特殊时间下单金额的波动指标
        /// </summary>
        public string AllFddifMinusTwoaSdHourbinAmtaorder { get; set; }

        /// <summary>
        /// 特定支付方式金额指标
        /// </summary>
        public string AllFdescMeanPayonlinepaymentAmtorder { get; set; }

        /// <summary>
        /// 用户购买时间波动系数1
        /// </summary>
        public string AllGddescMinusLoantimenowMaxDaydiff { get; set; }

        /// <summary>
        /// 用户购买时间波动系数2
        /// </summary>
        public string AllGddescMinusLoantimenowMinHourdiff { get; set; }

        /// <summary>
        /// 用户特殊支付金额占比
        /// </summary>
        public string AllGddifDivCashondeliveryallSumPayAmtorder { get; set; }

        /// <summary>
        /// 用户特殊支付金额指标
        /// </summary>
        public string AllGddifDivOnlinepaymentallSumPayAmtorder { get; set; }

        /// <summary>
        /// 用户特殊商品差异性指标
        /// </summary>
        public string AllGddifDivSportsoutdoorallNCntprdcategory { get; set; }

        /// <summary>
        /// 用户特殊订单占比
        /// </summary>
        public string AllGddifDivideFailallNStsCntorder { get; set; }

        /// <summary>
        /// 用户特殊时间下单量指标
        /// </summary>
        public string AllGddifDivideFiveeightallNHourCntorder { get; set; }

        /// <summary>
        /// 用户特殊商品差异性系数
        /// </summary>
        public string AllGddifDividePhonedigitalallNCntprdcategory { get; set; }

        /// <summary>
        /// 用户特殊订单量指标
        /// </summary>
        public string AllGddifMinusCaMaxProductCntaorder { get; set; }

        /// <summary>
        /// 用户特殊订单的差异性指标
        /// </summary>
        public string AllGddifMinusCaSumAorderCntproduct { get; set; }

        /// <summary>
        /// 用户特殊产品之间差异系数
        /// </summary>
        public string AllGddifMinusCsMedianProductCntaorder { get; set; }

        /// <summary>
        /// 用户特殊订单下单金额异常指标
        /// </summary>
        public string AllGddifMinusCsSkewAorderAmtaorder { get; set; }

        /// <summary>
        /// 用户购买商品的波动性指标
        /// </summary>
        public string AllGddifMinusSaEntropyAorderCntproduct { get; set; }

        /// <summary>
        /// 用户购买商品量
        /// </summary>
        public string AllGddifMinusSaSumAorderCntproduct { get; set; }

        /// <summary>
        /// 用户购买固定商品的稳定性
        /// </summary>
        public string AllGddifMinusSaSumProductCntaorder { get; set; }

        /// <summary>
        /// 用户购买固定商品的差异
        /// </summary>
        public string AllGdescMeanProductCntaorder { get; set; }

        /// <summary>
        /// 用户购买特殊订单的数量
        /// </summary>
        public string AllGdescMeanSorderAmtaorder { get; set; }

        /// <summary>
        /// 用户特殊订单金额指标
        /// </summary>
        public string AllGdescMinCorderAmtaorder { get; set; }

        /// <summary>
        /// 用户下单稳定性系数
        /// </summary>
        public string AllGdescMinPhoneSumamt { get; set; }

        /// <summary>
        /// 用户购买稳定性指标
        /// </summary>
        public string AllGdescMinRecaddrcitySumamt { get; set; }

        /// <summary>
        /// 用户下单稳定性
        /// </summary>
        public string AllGdescMinRecaddrprovinceAvgamt { get; set; }

        /// <summary>
        /// 用户购物行为稳定性指标
        /// </summary>
        public string AllGdescNormentropyPhoneCntorder { get; set; }

        /// <summary>
        /// 用户特殊购买行为稳定性指标
        /// </summary>
        public string AllGdescNormentropyProductCntsorder { get; set; }

        /// <summary>
        /// 用户特殊订单容量指标
        /// </summary>
        public string AllGdescQlSorderAmtaorder { get; set; }

        /// <summary>
        /// 用户下单跨度行为指标
        /// </summary>
        public string AllTsdescAmtorderdiffAmtdiffMedian { get; set; }

        /// <summary>
        /// 用户下单跨度行为稳定性
        /// </summary>
        public string AllTsdescAmtorderdiffAmtdiffQu { get; set; }

        /// <summary>
        /// 用户下单跨度行为波动性
        /// </summary>
        public string AllTsdescAmtorderdiffAmtdiffSum { get; set; }

        /// <summary>
        /// 用户下单跨度特殊差异性
        /// </summary>
        public string AllTsdescAmtorderdiffTimediffCv { get; set; }

        /// <summary>
        /// 用户下单跨度可靠性
        /// </summary>
        public string AllTsdescAmtorderdiffTimediffQfour { get; set; }

        /// <summary>
        /// 用户下单金额差异稳定度
        /// </summary>
        public string AllTsdescAmtorderdiffTimediffQsix { get; set; }

        /// <summary>
        /// 用户下单时间稳定度
        /// </summary>
        public string AllTsdescAmtorderdiffTimediffQu { get; set; }

        /// <summary>
        /// 用户下单行为差异度
        /// </summary>
        public string AllTsdescAmtorderdiffVamtQnine { get; set; }

        /// <summary>
        /// 用户可信度指标
        /// </summary>
        public string JdauthFddescExistChannelfinanceAuth { get; set; }

        /// <summary>
        /// 用户授信稳定性指标
        /// </summary>
        public string JdauthFddescExistLoginnameEqualPhone { get; set; }

        /// <summary>
        /// 用户信用欺诈指标
        /// </summary>
        public string JdauthFddescMinusNowauthtimeSeconds { get; set; }

        /// <summary>
        /// 用户信用稳定性指标
        /// </summary>
        public string JdbankcardDescDivideNOwnernameReceiver { get; set; }

        /// <summary>
        /// 用户可信度差异
        /// </summary>
        public string JdbankcardDescNBankphoneAuthphone { get; set; }

        /// <summary>
        /// 用户可信度波动系数
        /// </summary>
        public string JdbankcardDescNOwnernameReceiver { get; set; }

        /// <summary>
        /// 用户稳定性支付系数
        /// </summary>
        public string JdbankcardDiffDivideNndBindphone { get; set; }

        /// <summary>
        /// 用户主流支付差异
        /// </summary>
        public string JdbankcardFdescNBanknameMajorfourbanks { get; set; }

        /// <summary>
        /// 用户支付信用系数
        /// </summary>
        public string JdbankcardFdescNBanknameOthers { get; set; }

        /// <summary>
        /// 用户支付差异系数
        /// </summary>
        public string JdbankcardFdiffDivideAbcallCntbankname { get; set; }

        /// <summary>
        /// 用户信用卡稳定性
        /// </summary>
        public string JdbankcardFdiffDivideCreditallCntcardtype { get; set; }

        /// <summary>
        /// 用户支付稳定性
        /// </summary>
        public string JdbankcardFdiffDividePostallCntbankname { get; set; }

        /// <summary>
        /// 用户信用指标
        /// </summary>
        public string JdbtGddescExtractCreditscoreBt { get; set; }

        /// <summary>
        /// 用户信用稳定系数
        /// </summary>
        public string JdbtGddiffMinusOverdraftquotaBtAmt { get; set; }

        /// <summary>
        /// 用户活动金额指标
        /// </summary>
        public string JdoneoneoneonesumGdescAmt { get; set; }

        /// <summary>
        /// 用户居住稳定性指标
        /// </summary>
        public string JdreceivaddrDescNAddress { get; set; }

        /// <summary>
        /// 用户收货地址差异系数
        /// </summary>
        public string JdreceivaddrDescNNaemail { get; set; }

        /// <summary>
        /// 用户收货地址稳定性指标
        /// </summary>
        public string JdreceivaddrDescRateNafixphone { get; set; }

        /// <summary>
        /// 用户活动金额范围系数
        /// </summary>
        public string JdsixoneeightsumGdescAmt { get; set; }

        /// <summary>
        /// 用户注册差异性指标
        /// </summary>
        public string JduserFddescExistWebloginnameLogname { get; set; }

        /// <summary>
        /// 用户下单时间金额总共的时间精度
        /// </summary>
        public string JduserFddescNdCompareThreenames { get; set; }

        /// <summary>
        /// 用户的绑定粘性指标
        /// </summary>
        public string JduserIsbindBothqqwechat { get; set; }

        /// <summary>
        /// 1年内短时间金额稳定性指标
        /// </summary>
        public string OneyFddifDivideSevenaRangeHourbinAmtaorder { get; set; }

        /// <summary>
        /// 1年内短时间金额占比
        /// </summary>
        public string OneyFddifMinusOneaRangeHourbinAmtaorder { get; set; }

        /// <summary>
        /// 1年内短时间订单金额稳定性指标
        /// </summary>
        public string OneyFddifMinusSixaRangeHourbinAmtaorder { get; set; }

        /// <summary>
        /// 1年内特殊订单金额平均水平
        /// </summary>
        public string OneyFdescMeanPaycashondeliveryAmtorder { get; set; }

        /// <summary>
        /// 1年内特殊订单金额异常指标
        /// </summary>
        public string OneyFdescSumMeaninvoicecontentAmtorder { get; set; }

        /// <summary>
        /// 1年内在线支付金额占比
        /// </summary>
        public string OneyGddifDivOnlinepaymentallSumPayAmtorder { get; set; }

        /// <summary>
        /// 1年内特殊订单购买能力
        /// </summary>
        public string OneyGddifMinusCaMedianAorderAmtaorder { get; set; }

        /// <summary>
        /// 1年内取消订单订单金额差异性指标
        /// </summary>
        public string OneyGddifMinusCaSdAmtbinAmtaorder { get; set; }

        /// <summary>
        /// 1年内订单数量总和差异
        /// </summary>
        public string OneyGddifMinusCaSumAorderCntproduct { get; set; }

        /// <summary>
        /// 1年内特殊订单金额波动性指标
        /// </summary>
        public string OneyGddifMinusSaEntropyAmtbinAmtaorder { get; set; }

        /// <summary>
        /// 1年内地址差异指标
        /// </summary>
        public string OneyGdescCvRecaddrcityAvgamt { get; set; }

        /// <summary>
        /// 1年内特殊订单金额分段差异性指标
        /// </summary>
        public string OneyGdescNormentropyAmtbinAmtsorder { get; set; }

        /// <summary>
        /// 1年内订单金额特殊时间差异性系数
        /// </summary>
        public string OneyTsdescAmtorderdiffTimediffQsix { get; set; }

        /// <summary>
        /// 1年内下单时间金额波动指标
        /// </summary>
        public string OneyTsdescAmtorderdiffVamtRange { get; set; }

        /// <summary>
        /// 芝麻会员在商户端的身份标识。
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 6月内特殊时间下波动性指标
        /// </summary>
        public string SixmFdescCvHourCntorder { get; set; }

        /// <summary>
        /// 6月内在线支付总金额的占比
        /// </summary>
        public string SixmGddifDivOnlinepaymentallSumPayAmtorder { get; set; }

        /// <summary>
        /// 6月内电子产品类目占比
        /// </summary>
        public string SixmGddifDivPhonedigitalallNCntprdcategory { get; set; }

        /// <summary>
        /// 6月内特殊下单量的占比
        /// </summary>
        public string SixmGddifDivSixmallNHourtwefourteenCntorder { get; set; }

        /// <summary>
        /// 6月内短时间下单占比
        /// </summary>
        public string SixmGddifDivideFiveeightallNHourCntorder { get; set; }

        /// <summary>
        /// 6月内异常商品占比
        /// </summary>
        public string SixmGddifMinusCaSumAorderCntproduct { get; set; }

        /// <summary>
        /// 6月内收货地址平均下单量的差异性指标
        /// </summary>
        public string SixmGdescMinRecaddrcityAvgamt { get; set; }

        /// <summary>
        /// 6月内收货地址稳定性指标
        /// </summary>
        public string SixmGdescRangeRecaddrprovinceAvgamt { get; set; }

        /// <summary>
        /// 用户活动期间的下单系数
        /// </summary>
        public string SpringfestivalGdescQuAamt { get; set; }

        /// <summary>
        /// 3个月内特殊时段购买能力
        /// </summary>
        public string ThreemFddifMinusSevenaQdHourbinAmtaorder { get; set; }

        /// <summary>
        /// 3月内特殊用途商品占比
        /// </summary>
        public string ThreemGddifDivTravelrechargeallNCntprdcateg { get; set; }

        /// <summary>
        /// 3月内异常订单占比
        /// </summary>
        public string ThreemGddifDivideFailallNStsCntorder { get; set; }

        /// <summary>
        /// 3月内金额总和异常占比
        /// </summary>
        public string ThreemGddifDivideNullallSumPayAmtorder { get; set; }

        /// <summary>
        /// 3月内特殊订单金额指标
        /// </summary>
        public string ThreemGdescSumSorderAmtaorder { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddhhmmssSSS，后13位为自增数字。
        /// </summary>
        public string TransactionId { get; set; }

        #region IZmopRequest Members
        private string apiVersion = "1.0";
		private string channel;
		private string platform;
        private string scene;
		private string extParams;

		public void SetChannel(string channel){
            this.channel = channel;
        }

        public string GetChannel(){
            return this.channel;
        }

        public void SetPlatform(String platform){
			this.platform=platform;
		}

    	public string GetPlatform(){
    		return this.platform;
    	}

    	public void SetScene(String scene){
    		this.scene=scene;
    	}

    	public string GetScene(){
    		return this.scene;
    	}

        public void SetExtParams(String extParams){
            this.extParams=extParams;
        }

        public string GetExtParams(){
            return this.extParams;
        }

        public string GetApiName()
        {
            return "zhima.credit.msxf.onlinejdscore.query";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            ZmopDictionary parameters = new ZmopDictionary();
            parameters.Add("all_fddif_divide_sixa_qd_hourbin_amtaorder", this.AllFddifDivideSixaQdHourbinAmtaorder);
            parameters.Add("all_fddif_minus_fivea_range_hourbin_amtaorder", this.AllFddifMinusFiveaRangeHourbinAmtaorder);
            parameters.Add("all_fddif_minus_twoa_sd_hourbin_amtaorder", this.AllFddifMinusTwoaSdHourbinAmtaorder);
            parameters.Add("all_fdesc_mean_payonlinepayment_amtorder", this.AllFdescMeanPayonlinepaymentAmtorder);
            parameters.Add("all_gddesc_minus_loantimenow_max_daydiff", this.AllGddescMinusLoantimenowMaxDaydiff);
            parameters.Add("all_gddesc_minus_loantimenow_min_hourdiff", this.AllGddescMinusLoantimenowMinHourdiff);
            parameters.Add("all_gddif_div_cashondeliveryall_sum_pay_amtorder", this.AllGddifDivCashondeliveryallSumPayAmtorder);
            parameters.Add("all_gddif_div_onlinepaymentall_sum_pay_amtorder", this.AllGddifDivOnlinepaymentallSumPayAmtorder);
            parameters.Add("all_gddif_div_sportsoutdoorall_n_cntprdcategory", this.AllGddifDivSportsoutdoorallNCntprdcategory);
            parameters.Add("all_gddif_divide_failall_n_sts_cntorder", this.AllGddifDivideFailallNStsCntorder);
            parameters.Add("all_gddif_divide_fiveeightall_n_hour_cntorder", this.AllGddifDivideFiveeightallNHourCntorder);
            parameters.Add("all_gddif_divide_phonedigitalall_n_cntprdcategory", this.AllGddifDividePhonedigitalallNCntprdcategory);
            parameters.Add("all_gddif_minus_ca_max_product_cntaorder", this.AllGddifMinusCaMaxProductCntaorder);
            parameters.Add("all_gddif_minus_ca_sum_aorder_cntproduct", this.AllGddifMinusCaSumAorderCntproduct);
            parameters.Add("all_gddif_minus_cs_median_product_cntaorder", this.AllGddifMinusCsMedianProductCntaorder);
            parameters.Add("all_gddif_minus_cs_skew_aorder_amtaorder", this.AllGddifMinusCsSkewAorderAmtaorder);
            parameters.Add("all_gddif_minus_sa_entropy_aorder_cntproduct", this.AllGddifMinusSaEntropyAorderCntproduct);
            parameters.Add("all_gddif_minus_sa_sum_aorder_cntproduct", this.AllGddifMinusSaSumAorderCntproduct);
            parameters.Add("all_gddif_minus_sa_sum_product_cntaorder", this.AllGddifMinusSaSumProductCntaorder);
            parameters.Add("all_gdesc_mean_product_cntaorder", this.AllGdescMeanProductCntaorder);
            parameters.Add("all_gdesc_mean_sorder_amtaorder", this.AllGdescMeanSorderAmtaorder);
            parameters.Add("all_gdesc_min_corder_amtaorder", this.AllGdescMinCorderAmtaorder);
            parameters.Add("all_gdesc_min_phone_sumamt", this.AllGdescMinPhoneSumamt);
            parameters.Add("all_gdesc_min_recaddrcity_sumamt", this.AllGdescMinRecaddrcitySumamt);
            parameters.Add("all_gdesc_min_recaddrprovince_avgamt", this.AllGdescMinRecaddrprovinceAvgamt);
            parameters.Add("all_gdesc_normentropy_phone_cntorder", this.AllGdescNormentropyPhoneCntorder);
            parameters.Add("all_gdesc_normentropy_product_cntsorder", this.AllGdescNormentropyProductCntsorder);
            parameters.Add("all_gdesc_ql_sorder_amtaorder", this.AllGdescQlSorderAmtaorder);
            parameters.Add("all_tsdesc_amtorderdiff_amtdiff_median", this.AllTsdescAmtorderdiffAmtdiffMedian);
            parameters.Add("all_tsdesc_amtorderdiff_amtdiff_qu", this.AllTsdescAmtorderdiffAmtdiffQu);
            parameters.Add("all_tsdesc_amtorderdiff_amtdiff_sum", this.AllTsdescAmtorderdiffAmtdiffSum);
            parameters.Add("all_tsdesc_amtorderdiff_timediff_cv", this.AllTsdescAmtorderdiffTimediffCv);
            parameters.Add("all_tsdesc_amtorderdiff_timediff_qfour", this.AllTsdescAmtorderdiffTimediffQfour);
            parameters.Add("all_tsdesc_amtorderdiff_timediff_qsix", this.AllTsdescAmtorderdiffTimediffQsix);
            parameters.Add("all_tsdesc_amtorderdiff_timediff_qu", this.AllTsdescAmtorderdiffTimediffQu);
            parameters.Add("all_tsdesc_amtorderdiff_vamt_qnine", this.AllTsdescAmtorderdiffVamtQnine);
            parameters.Add("jdauth_fddesc_exist_channelfinance_auth", this.JdauthFddescExistChannelfinanceAuth);
            parameters.Add("jdauth_fddesc_exist_loginname_equal_phone", this.JdauthFddescExistLoginnameEqualPhone);
            parameters.Add("jdauth_fddesc_minus_nowauthtime_seconds", this.JdauthFddescMinusNowauthtimeSeconds);
            parameters.Add("jdbankcard_desc_divide_n_ownername_receiver", this.JdbankcardDescDivideNOwnernameReceiver);
            parameters.Add("jdbankcard_desc_n_bankphone_authphone", this.JdbankcardDescNBankphoneAuthphone);
            parameters.Add("jdbankcard_desc_n_ownername_receiver", this.JdbankcardDescNOwnernameReceiver);
            parameters.Add("jdbankcard_diff_divide_nnd_bindphone", this.JdbankcardDiffDivideNndBindphone);
            parameters.Add("jdbankcard_fdesc_n_bankname_majorfourbanks", this.JdbankcardFdescNBanknameMajorfourbanks);
            parameters.Add("jdbankcard_fdesc_n_bankname_others", this.JdbankcardFdescNBanknameOthers);
            parameters.Add("jdbankcard_fdiff_divide_abcall_cntbankname", this.JdbankcardFdiffDivideAbcallCntbankname);
            parameters.Add("jdbankcard_fdiff_divide_creditall_cntcardtype", this.JdbankcardFdiffDivideCreditallCntcardtype);
            parameters.Add("jdbankcard_fdiff_divide_postall_cntbankname", this.JdbankcardFdiffDividePostallCntbankname);
            parameters.Add("jdbt_gddesc_extract_creditscore_bt", this.JdbtGddescExtractCreditscoreBt);
            parameters.Add("jdbt_gddiff_minus_overdraftquota_bt_amt", this.JdbtGddiffMinusOverdraftquotaBtAmt);
            parameters.Add("jdoneoneoneonesum_gdesc_amt", this.JdoneoneoneonesumGdescAmt);
            parameters.Add("jdreceivaddr_desc_n_address", this.JdreceivaddrDescNAddress);
            parameters.Add("jdreceivaddr_desc_n_naemail", this.JdreceivaddrDescNNaemail);
            parameters.Add("jdreceivaddr_desc_rate_nafixphone", this.JdreceivaddrDescRateNafixphone);
            parameters.Add("jdsixoneeightsum_gdesc_amt", this.JdsixoneeightsumGdescAmt);
            parameters.Add("jduser_fddesc_exist_webloginname_logname", this.JduserFddescExistWebloginnameLogname);
            parameters.Add("jduser_fddesc_nd_compare_threenames", this.JduserFddescNdCompareThreenames);
            parameters.Add("jduser_isbind_bothqqwechat", this.JduserIsbindBothqqwechat);
            parameters.Add("oney_fddif_divide_sevena_range_hourbin_amtaorder", this.OneyFddifDivideSevenaRangeHourbinAmtaorder);
            parameters.Add("oney_fddif_minus_onea_range_hourbin_amtaorder", this.OneyFddifMinusOneaRangeHourbinAmtaorder);
            parameters.Add("oney_fddif_minus_sixa_range_hourbin_amtaorder", this.OneyFddifMinusSixaRangeHourbinAmtaorder);
            parameters.Add("oney_fdesc_mean_paycashondelivery_amtorder", this.OneyFdescMeanPaycashondeliveryAmtorder);
            parameters.Add("oney_fdesc_sum_meaninvoicecontent_amtorder", this.OneyFdescSumMeaninvoicecontentAmtorder);
            parameters.Add("oney_gddif_div_onlinepaymentall_sum_pay_amtorder", this.OneyGddifDivOnlinepaymentallSumPayAmtorder);
            parameters.Add("oney_gddif_minus_ca_median_aorder_amtaorder", this.OneyGddifMinusCaMedianAorderAmtaorder);
            parameters.Add("oney_gddif_minus_ca_sd_amtbin_amtaorder", this.OneyGddifMinusCaSdAmtbinAmtaorder);
            parameters.Add("oney_gddif_minus_ca_sum_aorder_cntproduct", this.OneyGddifMinusCaSumAorderCntproduct);
            parameters.Add("oney_gddif_minus_sa_entropy_amtbin_amtaorder", this.OneyGddifMinusSaEntropyAmtbinAmtaorder);
            parameters.Add("oney_gdesc_cv_recaddrcity_avgamt", this.OneyGdescCvRecaddrcityAvgamt);
            parameters.Add("oney_gdesc_normentropy_amtbin_amtsorder", this.OneyGdescNormentropyAmtbinAmtsorder);
            parameters.Add("oney_tsdesc_amtorderdiff_timediff_qsix", this.OneyTsdescAmtorderdiffTimediffQsix);
            parameters.Add("oney_tsdesc_amtorderdiff_vamt_range", this.OneyTsdescAmtorderdiffVamtRange);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("sixm_fdesc_cv_hour_cntorder", this.SixmFdescCvHourCntorder);
            parameters.Add("sixm_gddif_div_onlinepaymentall_sum_pay_amtorder", this.SixmGddifDivOnlinepaymentallSumPayAmtorder);
            parameters.Add("sixm_gddif_div_phonedigitalall_n_cntprdcategory", this.SixmGddifDivPhonedigitalallNCntprdcategory);
            parameters.Add("sixm_gddif_div_sixmall_n_hourtwefourteen_cntorder", this.SixmGddifDivSixmallNHourtwefourteenCntorder);
            parameters.Add("sixm_gddif_divide_fiveeightall_n_hour_cntorder", this.SixmGddifDivideFiveeightallNHourCntorder);
            parameters.Add("sixm_gddif_minus_ca_sum_aorder_cntproduct", this.SixmGddifMinusCaSumAorderCntproduct);
            parameters.Add("sixm_gdesc_min_recaddrcity_avgamt", this.SixmGdescMinRecaddrcityAvgamt);
            parameters.Add("sixm_gdesc_range_recaddrprovince_avgamt", this.SixmGdescRangeRecaddrprovinceAvgamt);
            parameters.Add("springfestival_gdesc_qu_aamt", this.SpringfestivalGdescQuAamt);
            parameters.Add("threem_fddif_minus_sevena_qd_hourbin_amtaorder", this.ThreemFddifMinusSevenaQdHourbinAmtaorder);
            parameters.Add("threem_gddif_div_travelrechargeall_n_cntprdcateg", this.ThreemGddifDivTravelrechargeallNCntprdcateg);
            parameters.Add("threem_gddif_divide_failall_n_sts_cntorder", this.ThreemGddifDivideFailallNStsCntorder);
            parameters.Add("threem_gddif_divide_nullall_sum_pay_amtorder", this.ThreemGddifDivideNullallSumPayAmtorder);
            parameters.Add("threem_gdesc_sum_sorder_amtaorder", this.ThreemGdescSumSorderAmtaorder);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
