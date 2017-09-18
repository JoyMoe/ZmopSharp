using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.customer.certify.initial
    /// </summary>
    public class ZhimaCustomerCertifyInitialRequest : IZmopRequest<ZhimaCustomerCertifyInitialResponse>
    {
        /// <summary>
        /// 业务扩展参数入参，传递方式例如{"xx":"xxxxx"}; 针对KBA的认证方式需要关注，biz_params中需要传入入参： {"verifyScene":"向芝麻申请获得的scene值"}
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 与芝麻信用签订的合约外标，即使合约改签或续签该值不会发生变化。请联系技术支持
        /// </summary>
        public string ContractFlag { get; set; }

        /// <summary>
        /// 不同身份类型的参数列表，json字符串的key-value格式： 如： 当identity_type= "BY_CERTNO_AND_NAME";时 identity_param={"certNo":"xxx","name":"张三","certType":"IDENTITY_CARD","mobileNo":"13901234567"}; 或者 当identity_type= "BY_MOBILE_NO";时 identity_param={"mobileNo":"13901234567"}; 或者 当identify_type="BY_CERT_IMAGE" identity_param={"frontCertImage":"oioiweroeworewoiho2323","backCertImage":"dsrrwerewew"}
        /// </summary>
        public string IdentityParam { get; set; }

        /// <summary>
        /// 身份标识类型（后续可以扩展）： BY_CERTNO_AND_NAME:按照身份证+姓名（手机号可选）进行身份识别 BY_MOBILE_NO:按照手机号进行身份识别 BY_CERT_IMAGE: 根据证件图片识别
        /// </summary>
        public string IdentityType { get; set; }

        /// <summary>
        /// 商户页面回调地址，芝麻认证完成后通过此url地址回传给商户认证的结果； SDK模式接入的场景为非必填项，其他渠道类型的必填项；
        /// </summary>
        public string PageUrl { get; set; }

        /// <summary>
        /// 当前使用的产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户App的回调地址，通过商户App发起人脸核身的芝麻认证时必传；其他场景为非必填项；
        /// </summary>
        public string SchemaUrl { get; set; }

        /// <summary>
        /// 请求来源类型，为比填项， 例如h5, pc , app, sdk,window； 1.h5 ：商户H5端接入芝麻应用的场景； 2.pc：商户pc端接入芝麻认证的场景； 3.app：商户app应用接入芝麻认证的场景； 4.sdk：商户调用芝麻的sdk进行芝麻认证的场景: 5.window：服务窗进行芝麻认证的场景；
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// 芝麻认证过程中的冗余字段，在认证申请时传入，在结果页面回调中原样透传给商户端。支持json格式。 【建议使用方式】用于商户端唯一标记发起认证的用户信息，在接收到芝麻信用认证结果回调后确定用户
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddhhmmssSSS，后13位为自增数字。
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
            return "zhima.customer.certify.initial";
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
            parameters.Add("contract_flag", this.ContractFlag);
            parameters.Add("identity_param", this.IdentityParam);
            parameters.Add("identity_type", this.IdentityType);
            parameters.Add("page_url", this.PageUrl);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("schema_url", this.SchemaUrl);
            parameters.Add("source_type", this.SourceType);
            parameters.Add("state", this.State);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
