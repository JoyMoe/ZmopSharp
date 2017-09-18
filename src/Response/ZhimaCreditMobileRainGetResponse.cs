using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Zmop.Api.Domain;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditMobileRainGetResponse.
    /// </summary>
    public class ZhimaCreditMobileRainGetResponse : ZmopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 手机号的风险代码，风险名称，风险描述，以list形式返回
        /// </summary>
        [XmlArray("info_codes")]
        [XmlArrayItem("r_a_i_n_info_code_element")]
        public List<RAINInfoCodeElement> InfoCodes { get; set; }

        /// <summary>
        /// 手机号rain分。取值为[0,100]。得分越高，风险越高。
        /// </summary>
        [XmlElement("rain_score")]
        public long RainScore { get; set; }
    }
}
