using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.credit.bqs.defaultscore.query
    /// </summary>
    public class ZhimaCreditBqsDefaultscoreQueryRequest : IZmopRequest<ZhimaCreditBqsDefaultscoreQueryResponse>
    {
        /// <summary>
        /// 申请事件通过比率
        /// </summary>
        public string AcceptPercentApply { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public Nullable<long> Age { get; set; }

        /// <summary>
        /// 申请时间（小时，0-23）
        /// </summary>
        public string ApplyHour { get; set; }

        /// <summary>
        /// 多头申请商户类型数量
        /// </summary>
        public Nullable<long> ApplyPartnerTypeCount { get; set; }

        /// <summary>
        /// 黑名单命中个数
        /// </summary>
        public Nullable<long> BlackCount { get; set; }

        /// <summary>
        /// 本人主要通话活动区域在几线城市
        /// </summary>
        public string CallActiveArea { get; set; }

        /// <summary>
        /// 排除被叫电话很短的联系人个数
        /// </summary>
        public Nullable<long> ContactExcludedCount { get; set; }

        /// <summary>
        /// 朋友圈活动区域在几线城市
        /// </summary>
        public string ContactsActiveArea { get; set; }

        /// <summary>
        /// 关联设备数量
        /// </summary>
        public Nullable<long> DeviceCount { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// GPS城市数量
        /// </summary>
        public Nullable<long> GpsCityCount { get; set; }

        /// <summary>
        /// 全天未使用通话和短信功能天数
        /// </summary>
        public Nullable<long> InactiveDays { get; set; }

        /// <summary>
        /// IP城市数量
        /// </summary>
        public Nullable<long> IpCityCount { get; set; }

        /// <summary>
        /// 设备中借贷app数量
        /// </summary>
        public Nullable<long> LoanAppCount { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 多头申请商户数量
        /// </summary>
        public Nullable<long> MultiapplyCount { get; set; }

        /// <summary>
        /// 夜间通话次数
        /// </summary>
        public Nullable<long> NightCalls { get; set; }

        /// <summary>
        /// 联系人中非手机个数
        /// </summary>
        public Nullable<long> NoneMobileCount { get; set; }

        /// <summary>
        /// 仅有被叫联系人个数
        /// </summary>
        public Nullable<long> OnlyTerminCount { get; set; }

        /// <summary>
        /// 入网时长
        /// </summary>
        public Nullable<long> OpenDays { get; set; }

        /// <summary>
        /// 用户在商端的身份标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 该用户第一次事件距今时间
        /// </summary>
        public Nullable<long> PhoneDays { get; set; }

        /// <summary>
        /// 信用产品码，对应云产品的标识
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 省份代码
        /// </summary>
        public string ProvinceId { get; set; }

        /// <summary>
        /// 申请事件拒绝比率
        /// </summary>
        public string RejectPercentApply { get; set; }

        /// <summary>
        /// 话费消费总金额
        /// </summary>
        public Nullable<long> SumInfoCostMoney { get; set; }

        /// <summary>
        /// 最常用联系人，多个用逗号分隔
        /// </summary>
        public string TopContact { get; set; }

        /// <summary>
        /// 代表一笔请求的唯一标志，该标识作为对账的关键信息，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常，有效期内的反复查询不重新计费。 transaction_id 推荐生成方式是：30位，（其中17位时间值（精确到毫秒）：yyyyMMddHHmmssSSS）加上（13位自增数字：1234567890123）
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 白名单等级
        /// </summary>
        public string WhiteGrade { get; set; }

        /// <summary>
        /// 上班时间手机号关联城市数量
        /// </summary>
        public string WorkCityCount { get; set; }

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
            return "zhima.credit.bqs.defaultscore.query";
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
            parameters.Add("accept_percent_apply", this.AcceptPercentApply);
            parameters.Add("age", this.Age);
            parameters.Add("apply_hour", this.ApplyHour);
            parameters.Add("apply_partner_type_count", this.ApplyPartnerTypeCount);
            parameters.Add("black_count", this.BlackCount);
            parameters.Add("call_active_area", this.CallActiveArea);
            parameters.Add("contact_excluded_count", this.ContactExcludedCount);
            parameters.Add("contacts_active_area", this.ContactsActiveArea);
            parameters.Add("device_count", this.DeviceCount);
            parameters.Add("gender", this.Gender);
            parameters.Add("gps_city_count", this.GpsCityCount);
            parameters.Add("inactive_days", this.InactiveDays);
            parameters.Add("ip_city_count", this.IpCityCount);
            parameters.Add("loan_app_count", this.LoanAppCount);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("multiapply_count", this.MultiapplyCount);
            parameters.Add("night_calls", this.NightCalls);
            parameters.Add("none_mobile_count", this.NoneMobileCount);
            parameters.Add("only_termin_count", this.OnlyTerminCount);
            parameters.Add("open_days", this.OpenDays);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("phone_days", this.PhoneDays);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("province_id", this.ProvinceId);
            parameters.Add("reject_percent_apply", this.RejectPercentApply);
            parameters.Add("sum_info_cost_money", this.SumInfoCostMoney);
            parameters.Add("top_contact", this.TopContact);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("white_grade", this.WhiteGrade);
            parameters.Add("work_city_count", this.WorkCityCount);
            return parameters;
        }

        #endregion
    }
}
