using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.info.authorize
    /// </summary>
    public class ZhimaAuthInfoAuthorizeRequest : IZmopRequest<ZhimaAuthInfoAuthorizeResponse>
    {
        /// <summary>
        /// 业务扩展字段,页面授权接口需要传入auth_code,channelType,state auth_code授权码,值取决于授权方式和身份类型 PC方式,身份类型identity_type=1: {"auth_code":"M_MOBILE_APPPC"} PC方式,身份类型identity_type=2: {"auth_code":"M_APPPC_CERT"} H5方式(身份类型identity_type为任何值): {"auth_code":"M_H5"} SDK方式(身份类型identity_type为任何值): {"auth_code":"M_APPSDK"} channelType渠道类型,每个授权码支持不同的渠道类型 appsdk:sdk接入 apppc:商户pc页面接入 api:后台api接入 windows:支付宝服务窗接入 app:商户app接入 state是商户自定义的数据,页面授权接口会原样把这个数据返回个商户
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 不同身份类型传入的参数列表,json字符串的key-value格式  身份类型identityType=1: {"mobileNo":"15158657683"}  身份类型identityType=2: {"certNo":"330100xxxxxxxxxxxx","name":"张三","certType":"IDENTITY_CARD"}
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 身份标识类型 <p>1:按照手机号进行授权</p> 2:按照身份证+姓名进行授权
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
            return "zhima.auth.info.authorize";
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
