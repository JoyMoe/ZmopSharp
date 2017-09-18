using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.hetrone.dasscore.query
    /// </summary>
    public class ZhimaCreditHetroneDasscoreQueryRequest : IZmopRequest<ZhimaCreditHetroneDasscoreQueryResponse>
    {
        /// <summary>
        /// 近3月交易总金额
        /// </summary>
        public Nullable<long> AmtBankcardTransacThreeMonths { get; set; }

        /// <summary>
        /// 近十二个月有交易的月数
        /// </summary>
        public Nullable<long> CntBankcardTransacTwelveMonths { get; set; }

        /// <summary>
        /// 手机在网时长
        /// </summary>
        public Nullable<long> CntMobileOnline { get; set; }

        /// <summary>
        /// 通讯录分数
        /// </summary>
        public Nullable<long> ContactScore { get; set; }

        /// <summary>
        /// 最近有无境外消费
        /// </summary>
        public Nullable<bool> ExistsBankcardTransacOversea { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 用户在商端的身份标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 信用产品码，对应云产品的标识
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 代表一笔请求的唯一标志，该标识作为对账的关键信息，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常，有效期内的反复查询不重新计费。 transaction_id 推荐生成方式是：30位，（其中17位时间值（精确到毫秒）：yyyyMMddHHmmssSSS）加上（13位自增数字：1234567890123）
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
            return "zhima.credit.hetrone.dasscore.query";
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
            parameters.Add("amt_bankcard_transac_three_months", this.AmtBankcardTransacThreeMonths);
            parameters.Add("cnt_bankcard_transac_twelve_months", this.CntBankcardTransacTwelveMonths);
            parameters.Add("cnt_mobile_online", this.CntMobileOnline);
            parameters.Add("contact_score", this.ContactScore);
            parameters.Add("exists_bankcard_transac_oversea", this.ExistsBankcardTransacOversea);
            parameters.Add("gender", this.Gender);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
