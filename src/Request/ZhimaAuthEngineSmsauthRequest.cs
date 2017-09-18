using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.engine.smsauth
    /// </summary>
    public class ZhimaAuthEngineSmsauthRequest : IZmopRequest<ZhimaAuthEngineSmsauthResponse>
    {
        /// <summary>
        /// 业务扩展字段,页面授权接口需要传入auth_code,channelType,state auth_code授权码,短信唤起支付宝客户端接口的值为M_SMS channelType渠道类型,每个授权码支持不同的渠道类型 appsdk:sdk接入 apppc:商户pc页面接入 api:后台api接入 windows:支付宝服务窗接入 app:商户app接入 state是商户自定义的数据,页面授权接口会原样把这个数据返回个商户
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 身份参数,短信唤起支付宝客户端授权需要传入姓名+证件类型+证件号码+手机号
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 身份类型,短信唤起支付宝客户端接口的身份识别类型为2:按照姓名+证件类型+证件号码+手机号进行授权
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
            return "zhima.auth.engine.smsauth";
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
