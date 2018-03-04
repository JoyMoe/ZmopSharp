using System;

namespace ZmopSharp.Exceptions
{
    public class NotAuthorizedException : ZmopException
    {
        public NotAuthorizedException(string message) : base(message)
        {
            //
        }
    }
}