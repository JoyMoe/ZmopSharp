using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.certification.info.query
    /// </summary>
    public class ZhimaCustomerCertificationInfoQueryRequest : IZmopRequest<ZhimaCustomerCertificationInfoQueryResponse>
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 商户id，商户在芝麻的唯一标识
        /// </summary>
        public string MerchantId { get; set; }

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
            return "zhima.customer.certification.info.query";
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
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("merchant_id", this.MerchantId);
            return parameters;
        }

        #endregion
    }
}
