using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.antifraud.verify
    /// </summary>
    public class ZhimaCreditAntifraudVerifyRequest : IZmopRequest<ZhimaCreditAntifraudVerifyResponse>
    {
        /// <summary>
        /// 地址信息。省+市+区/县+详细地址，长度不超过256，不要包含特殊字符，如","，"\"，"|"，"&"，"^"
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 银行卡号。中国大陆银行发布的银行卡:借记卡长度19位；信用卡长度16位；各位的取值位[0,9]的整数；不含虚拟卡
        /// </summary>
        public string BankCard { get; set; }

        /// <summary>
        /// 证件号。证件类型、证件号、姓名三要素均为必填参数
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。证件类型、证件号、姓名三要素均为必填参数
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 电子邮箱。合法email，字母小写，特殊符号以半角形式出现
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 国际移动设备标志，15位长度数字
        /// </summary>
        public string Imei { get; set; }

        /// <summary>
        /// ip地址。以"."分割的四段Ip，如 x.x.x.x，x为[0,255]之间的整数
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 物理地址。支持格式如下：xx:xx:xx:xx:xx:xx，xx-xx-xx-xx-xx-xx，xxxxxxxxxxxx，x取值范围[0,9]之间的整数及A，B，C，D，E，F
        /// </summary>
        public string Mac { get; set; }

        /// <summary>
        /// 手机号码。中国大陆合法手机号，长度11位，不含国家代码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名。长度不超过64，姓名中不要包含特殊字符，如","，"\"，"|"，"&"，"^"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品码。标记商户接入的具体产品；直接使用每个接口入参中示例值即可
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，长度64位以内字符串，仅限字母数字下划线组合。该标识作为业务调用的唯一标识，商户要保证其业务唯一性，使用相同transaction_id的查询，芝麻在一段时间内（一般为1天）返回首次查询结果，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// wifi的物理地址。支持格式如下：xx:xx:xx:xx:xx:xx，xx-xx-xx-xx-xx-xx，xxxxxxxxxxxx，x取值范围[0,9]之间的整数及A，B，C，D，E，F
        /// </summary>
        public string Wifimac { get; set; }

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
            return "zhima.credit.antifraud.verify";
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
            parameters.Add("address", this.Address);
            parameters.Add("bank_card", this.BankCard);
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("email", this.Email);
            parameters.Add("imei", this.Imei);
            parameters.Add("ip", this.Ip);
            parameters.Add("mac", this.Mac);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("wifimac", this.Wifimac);
            return parameters;
        }

        #endregion
    }
}
