using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.engine.organizationauth
    /// </summary>
    public class ZhimaAuthEngineOrganizationauthRequest : IZmopRequest<ZhimaAuthEngineOrganizationauthResponse>
    {
        /// <summary>
        /// 授权码入参，  1). 若identity_Type=2时，  {"auth_code":"M_P_COMPANY_CERT"}     2). 若identity_Type=5时，  {"auth_code":"M_P_COMPANY_UID"}
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 证件号目前支持2种： a. 工商注册号：NATIONAL_LEGAL   b. 社会统一信用代码 : NATIONAL_LEGAL_MERGE  1). 若identity_type=2时： identity_param={\"certNo\":\"440000400004160\",\"certType\":\"NATIONAL_LEGAL\",\"name\":\"中国移动通信集团广东有限公司\"}"  2). 若identity_type=5时： identity_param={\"userId\":\"2088xxxxxx\"}"
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 用户身份标识类型： 5： userId入参的类型标识； 2： 证件号和姓名的入参的类型标识
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
            return "zhima.auth.engine.organizationauth";
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
