using System;
using System.Xml.Serialization;

namespace Zmop.Api
{
    [Serializable]
    public abstract class ZmopResponse
    {
        //private bool success;
        private string errorCode;
        private string errorMessage;
        private string body;

        /// <summary>
        /// 错误码
        /// 对应 ErrCode
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
    }
}
