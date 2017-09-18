using System;
using System.Xml.Serialization;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCaseSeriesQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCaseSeriesQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户案件串联信息
        /// </summary>
        [XmlElement("user_case_series_info")]
        public CaseSeriesList UserCaseSeriesInfo { get; set; }
    }
}
