using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.engine.multiauth
    /// </summary>
    public class ZhimaAuthEngineMultiauthRequest : IZmopRequest<ZhimaAuthEngineMultiauthResponse>
    {
        /// <summary>
        /// 外部商户应用id
        /// </summary>
        public string AuthAppId { get; set; }

        /// <summary>
        /// 外部商户id
        /// </summary>
        public string AuthMerchantId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        public string UserId { get; set; }

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
            return "zhima.auth.engine.multiauth";
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
            parameters.Add("auth_app_id", this.AuthAppId);
            parameters.Add("auth_merchant_id", this.AuthMerchantId);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
