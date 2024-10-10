using Microservicios.Web.Service.IService;
using Microservicios.Web.Utility;
using Newtonsoft.Json.Linq;

namespace Microservicios.Web.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public TokenProvider(IHttpContextAccessor httpContextAccessor)
        {
            _contextAccessor = httpContextAccessor;
        }

        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.TokenCookie);
        }

        public string? GetToken()
        {
            var context = _contextAccessor.HttpContext;
            if (context != null)
            {
                var cookie = context.Request.Cookies[SD.TokenCookie];
                Console.WriteLine("Cookie Value: " + cookie);
                return cookie;
            }
            Console.WriteLine("No HttpContext available");
            return null;

        }

        public void SetToken(string token)
        {
            _contextAccessor.HttpContext?.Response.Cookies.Append(SD.TokenCookie, token);
        }
    }
}
