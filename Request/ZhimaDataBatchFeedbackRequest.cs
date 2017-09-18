using System;
using System.Collections.Generic;
using Zmop.Api.Response;
using Zmop.Api.Util;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.data.batch.feedback
    /// </summary>
    public class ZhimaDataBatchFeedbackRequest : IZmopUploadRequest<ZhimaDataBatchFeedbackResponse>
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        public string BizExtParams { get; set; }

        /// <summary>
        /// 单条数据的数据列，多个列以逗号隔开
        /// </summary>
        public string Columns { get; set; }

        /// <summary>
        /// 反馈的json格式的文件，其中{"records":  是每个文件的固定开头。
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 是反馈文件的数据编码，如果文件格式是UTF-8，则填写UTF-8，如果文件格式是GBK，则填写GBK
        /// </summary>
        public string FileCharset { get; set; }

        /// <summary>
        /// 文件描述信息
        /// </summary>
        public string FileDescription { get; set; }

        /// <summary>
        /// 反馈的数据类型，目前只支持json_data
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 主键列使用反馈字段进行组合，也可以使用反馈的某个单字段（确保主键稳定，而且可以很好的区分不同的数据）。例如order_no,pay_month或者order_no,bill_month组合，对于一个order_no只会有一条数据的情况，直接使用order_no作为主键列
        /// </summary>
        public string PrimaryKeyColumns { get; set; }

        /// <summary>
        /// 文件数据记录条数
        /// </summary>
        public string Records { get; set; }

        /// <summary>
        /// 芝麻系统中配置的值，由芝麻信用提供，需要匹配，测试反馈和正式反馈使用不同的type_id。 其中测试type_id与反馈字段模板会通过邮件统一提供给合作伙伴，在测试反馈通过之后，再通过邮件提供正式反馈type_id给合作伙伴。
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
			this.platform = platform;
		}

    	public string GetPlatform(){
    		return this.platform;
    	}

    	public void SetScene(String scene){
    		this.scene = scene;
    	}

    	public string GetScene(){
    		return this.scene;
    	}

        public void SetExtParams(String extParams){
            this.extParams = extParams;
        }

        public string GetExtParams(){
            return this.extParams;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "zhima.data.batch.feedback";
        }

        public IDictionary<string, string> GetParameters()
        {
            ZmopDictionary parameters = new ZmopDictionary();
            parameters.Add("biz_ext_params", this.BizExtParams);
            parameters.Add("columns", this.Columns);
            parameters.Add("file_charset", this.FileCharset);
            parameters.Add("file_description", this.FileDescription);
            parameters.Add("file_type", this.FileType);
            parameters.Add("primary_key_columns", this.PrimaryKeyColumns);
            parameters.Add("records", this.Records);
            parameters.Add("type_id", this.TypeId);
            return parameters;
        }

        #endregion

        #region IZmopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file", this.File);
            return parameters;
        }

        #endregion
    }
}
