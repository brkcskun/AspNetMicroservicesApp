﻿namespace Web.UI.Utilities
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string IdentityAPIBase { get; set; }

        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE,
        }
    }
}
