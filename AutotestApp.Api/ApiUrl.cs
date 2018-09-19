using AutotestApp.Common;
using System;

namespace AutotestApp.Api
{
    public static class ApiUrl
    {
        public static String ApiBaseUrl => Config.Instance.ApiBaseUrl;

        public static String BaseUrl => Config.Instance.BaseUrl;

        public static String Product => $"{ApiBaseUrl}product";

        public static String Login => $"{ApiBaseUrl}product";

        public static String Token => $"{ApiBaseUrl}/TOKEN";

        public static String GetCustomerBillingAddress => $"{ApiBaseUrl}/Quote/GetCustomerBillingAddress";

        public static String GetQuoteData => $"{ApiBaseUrl}/Quote/GetQuoteData";
    }
}