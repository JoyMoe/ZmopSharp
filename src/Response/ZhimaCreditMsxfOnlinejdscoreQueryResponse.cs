using System;
using System.Xml.Serialization;

namespace Zmop.Api.Response
{
    /// <summary>
    /// ZhimaCreditMsxfOnlinejdscoreQueryResponse.
    /// </summary>
    public class ZhimaCreditMsxfOnlinejdscoreQueryResponse : ZmopResponse
    {
        /// <summary>
        /// 模型预测成好用户（0）的概率值，取值范围 [0, 1]。
        /// </summary>
        [XmlElement("model_score")]
        public string ModelScore { get; set; }

        /// <summary>
        /// 预测结果值 {0, 1}，其中 0 表示好用户。
        /// </summary>
        [XmlElement("predict_result")]
        public long PredictResult { get; set; }

        /// <summary>
        /// 预测成 predict_result 的概率值，取值范围 [0.5, 1]
        /// </summary>
        [XmlElement("predict_score")]
        public string PredictScore { get; set; }
    }
}
