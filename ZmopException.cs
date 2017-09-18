using System;
using System.Runtime.Serialization;

namespace Zmop.Api
{
    /// <summary>
    /// ZMOP客户端异常。
    /// </summary>
    public class ZmopException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public ZmopException()
            : base()
        {
        }

        public ZmopException(string message)
            : base(message)
        {
        }

        protected ZmopException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ZmopException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ZmopException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
