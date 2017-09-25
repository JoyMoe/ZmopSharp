namespace ZmopSharp.Constants
{
    public static class Authorization
    {
        public static class IdentityType
        {
            public const int PhoneNumber = 1;
            public const int IdCard = 2;
        }
        public static class AuthCode
        {
            public const string PhoneNumberPc = "M_MOBILE_APPPC";
            public const string IdCardPc = "M_APPPC_CERT";
            public const string WebView = "M_H5";
            public const string AppSdk = "M_APPSDK";
        }
        public static class ChannelType
        {
            public const string AppSdk = "appsdk";
            public const string AppPc = "apppc";
            public const string App = "app";
            public const string Api = "api";
            public const string InAlipay = "windows";
        }
    }
}