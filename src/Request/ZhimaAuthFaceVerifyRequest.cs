using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.face.verify
    /// </summary>
    public class ZhimaAuthFaceVerifyRequest : IZmopRequest<ZhimaAuthFaceVerifyResponse>
    {
        /// <summary>
        /// 活体认证类型，目前有认证和授权两种类型；默认为授权类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 标识一次请求流水
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
            return "zhima.auth.face.verify";
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
            parameters.Add("biz_type", this.BizType);
            parameters.Add("images", this.Images);
            parameters.Add("token", this.Token);
            return parameters;
        }

        #endregion
    }
}
