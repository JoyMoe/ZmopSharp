using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.engine.protocol
    /// </summary>
    public class ZhimaAuthEngineProtocolRequest : IZmopRequest<ZhimaAuthEngineProtocolResponse>
    {
        /// <summary>
        /// 业务扩展入参
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 授权的身份标识参数
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 用户的身份标识类型\n3：身份证+姓名+手机号进行支付宝识别，核身，授权\n4：身份证+姓名+手机号（可选）进行公安网的核身，授权
        /// </summary>
        public string IdentityType { get; set; }

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
            return "zhima.auth.engine.protocol";
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
            parameters.Add("biz_params", this.BizParams);
            parameters.Add("identity_param", this.IdentityParam);
            parameters.Add("identity_type", this.IdentityType);
            return parameters;
        }

        #endregion
    }
}
