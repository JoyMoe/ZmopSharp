using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.kkcredit.abscore.query
    /// </summary>
    public class ZhimaCreditKkcreditAbscoreQueryRequest : IZmopRequest<ZhimaCreditKkcreditAbscoreQueryResponse>
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
        /// 当前正常的信用卡账户已用额度与可用额度之比的均值
        /// </summary>
        public string NormCdtBalUsedPctAvg { get; set; }

        /// <summary>
        /// 芝麻会员在商户端的身份标识。
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

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
            return "zhima.credit.kkcredit.abscore.query";
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
            parameters.Add("norm_cdt_bal_used_pct_avg", this.NormCdtBalUsedPctAvg);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
