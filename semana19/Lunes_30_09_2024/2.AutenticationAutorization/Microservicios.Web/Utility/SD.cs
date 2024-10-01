namespace Microservicios.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }

        public const string TokenCookie = "JwtToken";

        public const string RoleAdmin = "Admin";
        public const string RoleCustomer = "Customer";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
