using Microservicios.Web.Models;
using Microservicios.Web.Service.IService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Microservicios.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ITokenProvider _tokenProvider;

        public AuthController(IAuthService authService, ITokenProvider tokenProvider)
        {
            _authService = authService;
            _tokenProvider = tokenProvider;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            ResponseDto responseDto = await _authService.LoginAsync(loginRequestDto);
            if(responseDto != null && responseDto.IsSuccess)
            {
                LoginResponseDto loginResponseDto = 
                    JsonConvert.DeserializeObject<LoginResponseDto>(Convert.ToString(responseDto.Result));

                await SingInUser(loginResponseDto);
                _tokenProvider.SetToken(loginResponseDto.Token);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["error"] = responseDto.Message;
                return View(loginRequestDto);
            }
        }


        private async Task SingInUser(LoginResponseDto loginResponseDto)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.ReadJwtToken(loginResponseDto.Token);

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Email,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Email).Value));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub).Value));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Name,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Name).Value));

            identity.AddClaim(new Claim(ClaimTypes.Role,
                jwt.Claims.FirstOrDefault(x=>x.Type == "role").Value));

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
