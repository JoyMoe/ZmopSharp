using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.xueli.verify
    /// </summary>
    public class ZhimaCreditXueliVerifyRequest : IZmopRequest<ZhimaCreditXueliVerifyResponse>
    {
        /// <summary>
        /// 证件号码，暂时只支持身份证号
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，暂时支持身份证
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 院校名称
        /// </summary>
        public string CollegeName { get; set; }

        /// <summary>
        /// 学历类别：普通，研究生，成人，高等教育自学考试，网络教育，开放教育，不详
        /// </summary>
        public string EducationCategory { get; set; }

        /// <summary>
        /// 学历层次： 博士研究生，硕士研究生，研究生班， 第二学士学位，本科，高升本，专升本，第二本科 专科，专科(高职)，第二专科，夜大电大函大普通班，大学
        /// </summary>
        public string EducationDegree { get; set; }

        /// <summary>
        /// 毕业年份，格式为四位数的年份，如2018
        /// </summary>
        public string GraduateYear { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

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
            return "zhima.credit.xueli.verify";
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
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("college_name", this.CollegeName);
            parameters.Add("education_category", this.EducationCategory);
            parameters.Add("education_degree", this.EducationDegree);
            parameters.Add("graduate_year", this.GraduateYear);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            return parameters;
        }

        #endregion
    }
}
