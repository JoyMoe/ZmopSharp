using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.xueji.verify
    /// </summary>
    public class ZhimaCreditXuejiVerifyRequest : IZmopRequest<ZhimaCreditXuejiVerifyResponse>
    {
        /// <summary>
        /// 院校名称
        /// </summary>
        public string CollegeName { get; set; }

        /// <summary>
        /// 输入为数字： 1：表示普通全日制； 2：表示硕士或者博士研究生； 5：表示成人教育； 6：表示高等教育自学考试； 7：表示网络教育； 8：表示开放教育； 9：表示不详
        /// </summary>
        public string EducationCategory { get; set; }

        /// <summary>
        /// 学历层次：博士、硕士、本科、专科、成人。
        /// </summary>
        public string EducationDegree { get; set; }

        /// <summary>
        /// 入学年份，格式为四位数的年份，如2013
        /// </summary>
        public string EnrollmentYear { get; set; }

        /// <summary>
        /// 毕业年份，格式为四位数的年份，如2018
        /// </summary>
        public string GraduateYear { get; set; }

        /// <summary>
        /// 芝麻会员在商户端的身份标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddHHmmssSSS，后13位为自增数字。
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
            return "zhima.credit.xueji.verify";
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
            parameters.Add("college_name", this.CollegeName);
            parameters.Add("education_category", this.EducationCategory);
            parameters.Add("education_degree", this.EducationDegree);
            parameters.Add("enrollment_year", this.EnrollmentYear);
            parameters.Add("graduate_year", this.GraduateYear);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
