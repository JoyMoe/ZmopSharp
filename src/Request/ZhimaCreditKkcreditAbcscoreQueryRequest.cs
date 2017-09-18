using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.kkcredit.abcscore.query
    /// </summary>
    public class ZhimaCreditKkcreditAbcscoreQueryRequest : IZmopRequest<ZhimaCreditKkcreditAbcscoreQueryResponse>
    {
        /// <summary>
        /// 年龄
        /// </summary>
        public Nullable<long> Age { get; set; }

        /// <summary>
        /// 未销信用卡开户距今月数的平均数
        /// </summary>
        public string CrdAgeUnclsAvg { get; set; }

        /// <summary>
        /// 性别，男=1，女=0
        /// </summary>
        public Nullable<long> Gender { get; set; }

        /// <summary>
        /// 近90天深夜联系人
        /// </summary>
        public Nullable<long> LnizedLnitCttPpl { get; set; }

        /// <summary>
        /// 当前正常的信用卡账户已用额度与可用额度之比的均值
        /// </summary>
        public string NormCdtBalUsedPctAvg { get; set; }

        /// <summary>
        /// 芝麻会员在商户端的身份标识。
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 手机注册时长
        /// </summary>
        public Nullable<long> PhoneUseMth { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 近150天短信发送联系人
        /// </summary>
        public Nullable<long> SmsLonfizedSendPpl { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddhhmmssSSS，后13位为自增数字。
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 近5月套餐金额占比
        /// </summary>
        public string TrcLsmfiAvgPlanTotalPct { get; set; }

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
            return "zhima.credit.kkcredit.abcscore.query";
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
            parameters.Add("age", this.Age);
            parameters.Add("crd_age_uncls_avg", this.CrdAgeUnclsAvg);
            parameters.Add("gender", this.Gender);
            parameters.Add("lnized_lnit_ctt_ppl", this.LnizedLnitCttPpl);
            parameters.Add("norm_cdt_bal_used_pct_avg", this.NormCdtBalUsedPctAvg);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("phone_use_mth", this.PhoneUseMth);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("sms_lonfized_send_ppl", this.SmsLonfizedSendPpl);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("trc_lsmfi_avg_plan_total_pct", this.TrcLsmfiAvgPlanTotalPct);
            return parameters;
        }

        #endregion
    }
}
