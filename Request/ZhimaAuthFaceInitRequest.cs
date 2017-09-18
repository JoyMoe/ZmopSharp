using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.face.init
    /// </summary>
    public class ZhimaAuthFaceInitRequest : IZmopRequest<ZhimaAuthFaceInitResponse>
    {
        /// <summary>
        /// 应用的标识
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// 参数的加密串
        /// </summary>
        public string AuthMsg { get; set; }

        /// <summary>
        /// 用于标识使用人脸业务的类型是授权或者认证，默认为授权类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 不同商户的bundle_id,用来做缓存
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// 请求的sessionId
        /// </summary>
        public string Token { get; set; }

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
            return "zhima.auth.face.init";
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
            parameters.Add("api_key", this.ApiKey);
            parameters.Add("auth_msg", this.AuthMsg);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("bundle_id", this.BundleId);
            parameters.Add("token", this.Token);
            return parameters;
        }

        #endregion
    }
}
