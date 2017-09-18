using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.watchlist.brief.get
    /// </summary>
    public class ZhimaCreditWatchlistBriefGetRequest : IZmopRequest<ZhimaCreditWatchlistBriefGetResponse>
    {
        /// <summary>
        /// 证件类型对应的证件号码， 如：身份证号， 护照号，userId
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 当前支持3种类型的输入： IDENTITY_CARD (身份证) PASSPORT (护照) ALIPAY_USER_ID (支付宝uid)
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 当cert_type 为ALIPAY_USER_ID时证件名称可为空
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 芝麻开放平台信用产品码， 唯一标示云产品
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，长度64位以内字符串，仅限字母数字下划线组合。 该标识作为业务调用的唯一标识，商户要保证其业务唯一性，使用相同transaction_id的查询， 芝麻在一段时间内（一般为1天）返回首次查询结果， 超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费。
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
            return "zhima.credit.watchlist.brief.get";
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
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
