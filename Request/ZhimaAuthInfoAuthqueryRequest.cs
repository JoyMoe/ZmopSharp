using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.info.authquery
    /// </summary>
    public class ZhimaAuthInfoAuthqueryRequest : IZmopRequest<ZhimaAuthInfoAuthqueryResponse>
    {
        /// <summary>
        /// 授权类型，用于识别当前查询是否授权的分流； 可传参数“B2B”或“C2B”，自助商户请填写“C2B”。
        /// </summary>
        public string AuthCategory { get; set; }

        /// <summary>
        /// 不同身份类型传入的参数列表,json字符串的key-value格式 身份类型identityType=0: {"openId":"268801234567890123456"} 身份类型identityType=2: {"certNo":"330100xxxxxxxxxxxx","name":"张三","certType":"IDENTITY_CARD"}
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 身份标识类型 0:按照openId查询 2:按照身份证+姓名查询
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
            return "zhima.auth.info.authquery";
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
            parameters.Add("auth_category", this.AuthCategory);
            parameters.Add("identity_param", this.IdentityParam);
            parameters.Add("identity_type", this.IdentityType);
            return parameters;
        }

        #endregion
    }
}
