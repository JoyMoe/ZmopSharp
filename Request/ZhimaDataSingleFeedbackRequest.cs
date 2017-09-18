using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.data.single.feedback
    /// </summary>
    public class ZhimaDataSingleFeedbackRequest : IZmopRequest<ZhimaDataSingleFeedbackResponse>
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        public string BizExtParams { get; set; }

        /// <summary>
        /// 反馈的json格式的数据内容
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 主键使用反馈字段进行组合，也可以使用反馈的某个单字段（确保主键稳定，而且可以很好的区分不同的数据）。例如order_no#pay_month或者order_no#bill_month组合，对于一个order_no只会有一条数据的情况，直接使用order_no作为主键
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// 芝麻系统中配置的值，由芝麻信用提供，需要匹配，测试反馈和正式反馈使用不同的TYPE_ID
        /// </summary>
        public string TypeId { get; set; }

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
            return "zhima.data.single.feedback";
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
            parameters.Add("biz_ext_params", this.BizExtParams);
            parameters.Add("data", this.Data);
            parameters.Add("identity", this.Identity);
            parameters.Add("type_id", this.TypeId);
            return parameters;
        }

        #endregion
    }
}
