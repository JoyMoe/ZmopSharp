using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.auth.info.freeze
    /// </summary>
    public class ZhimaAuthInfoFreezeRequest : IZmopRequest<ZhimaAuthInfoFreezeResponse>
    {
        /// <summary>
        /// 用户在商户处申请业务的唯一识别码;\n每个申请仅对应一条冻结记录，若存在相同流水号的冻结周期将覆盖
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展字段，json字符串的key-value格式
        /// </summary>
        public string BizParams { get; set; }

        /// <summary>
        /// 申请原因 001: 贷款申请中, 002:信用卡申请中, 003:租车申请中, 004:信贷服务期内, 005:信贷逾期中
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 冻结结束时间，若该时间减去冻结开始时间的差值大于冻结周期，则该时间将赋值冻结开始时间+冻结周期
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 用户在商端的身份标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 冻结开始时间，若该时间早于系统当前时间，则会取当前时间作为冻结开始时间
        /// </summary>
        public string StartDate { get; set; }

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
            return "zhima.auth.info.freeze";
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
            parameters.Add("biz_params", this.BizParams);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("start_date", this.StartDate);
            return parameters;
        }

        #endregion
    }
}
