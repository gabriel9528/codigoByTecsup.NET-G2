using Microservicios.Web.Models;
using Microservicios.Web.Service.IService;
using Microservicios.Web.Utility;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Net;


//using System.IdentityModel.Tokens.Jwt;
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


        //*-----------------------Login------------------------------*
        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new LoginRequestDto();
            return View(loginRequestDto);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            ResponseDto responseDto = await _authService.LoginAsync(loginRequestDto);

            if (responseDto != null && responseDto.IsSuccess)
            {
                LoginResponseDto loginResponseDto = 
                    JsonConvert.DeserializeObject<LoginResponseDto>(Convert.ToString(responseDto.Result));

                await SignInUser(loginResponseDto);
                _tokenProvider.SetToken(loginResponseDto.Token);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["error"] = responseDto.Message;
                return View(loginRequestDto);
            }
        }



        //*-----------------------Register------------------------------*
        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = SD.RoleAdmin,
                    Value = SD.RoleAdmin,
                },
                new SelectListItem()
                {
                    Text = SD.RoleCustomer,
                    Value = SD.RoleCustomer,
                },
            };
            ViewBag.RoleList = roleList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationRequestDto registrationRequestDto)
        {
            ResponseDto responseDto = await _authService.RegisterAsync(registrationRequestDto);
            ResponseDto assignRole;
            if(responseDto != null && responseDto.IsSuccess)
            {
                if (string.IsNullOrEmpty(registrationRequestDto.Role))
                {
                    registrationRequestDto.Role = SD.RoleAdmin;
                }
                assignRole = await _authService.AssignRoleAsync(registrationRequestDto);
                if(assignRole != null && assignRole.IsSuccess)
                {
                    TempData["success"] = "Registration successfull";
                    return RedirectToAction(nameof(Login));
                }
            }
            else
            {
                TempData["error"] = responseDto.Message;
            }

            var roleList = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = SD.RoleAdmin,
                    Value = SD.RoleAdmin,
                },
                new SelectListItem()
                {
                    Text = SD.RoleCustomer,
                    Value = SD.RoleCustomer,
                },
            };
            ViewBag.RoleList = roleList;
            return View(registrationRequestDto);
        }


        //*-----------------------Logout------------------------------*
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            _tokenProvider.ClearToken();
            return RedirectToAction("Index", "Home");
        }


        private async Task SignInUser(LoginResponseDto loginResponseDto)
        {
            var handler = new JwtSecurityTokenHandler();

            var jwt = handler.ReadJwtToken(loginResponseDto.Token);

            //Crea una nueva identidad basada en reclamaciones (ClaimsIdentity) especificando el esquema
            //de autenticación de cookies 
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            //Agrega las reclamaciones del token JWT a la identidad
            //Extrae ciertos claims del token JWT (como email, sub, name y role) y los agrega a la identidad.
            //Los claims son pares clave-valor que representan información sobre el usuario, como su email, nombre y roles.
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Email,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Email).Value));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub).Value));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Name,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Name).Value));


            identity.AddClaim(new Claim(ClaimTypes.Name,
                jwt.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Email).Value));
            identity.AddClaim(new Claim(ClaimTypes.Role,
                jwt.Claims.FirstOrDefault(x => x.Type == "role").Value));

            //Crea un ClaimsPrincipal utilizando la identidad recién creada. Un ClaimsPrincipal puede
            //contener una o más identidades y representa al usuario autenticado en la aplicación.
            var principal = new ClaimsPrincipal(identity);

            //Usa el contexto de HTTP (HttpContext) para iniciar sesión al usuario autenticado con el esquema de autenticación de cookies.
            //Este paso establece una cookie de autenticación en el navegador del usuario, que se utilizará para mantener
            //la sesión autenticada del usuario en futuras solicitudes.
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }
    }
}
