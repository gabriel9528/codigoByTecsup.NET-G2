using Microservicios.Services.AuthAPI.Models.Dto;
using Microservicios.Services.AuthAPI.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservicios.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        private ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new ResponseDto();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegistrationRequestDto registrationRequestDto)
        {
            var errorMessage = await _authService.Register(registrationRequestDto);
            if(!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }

            _response.Message = "Usuario registrado con éxito.";
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var login = await _authService.Login(loginRequestDto);
            if(login.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Usuario o contraseña incorrectos.";
                return BadRequest(_response);
            }

            _response.Result = login;
            _response.Message = "Inicio de sesión exitoso.";
            return Ok(_response);
        }

        [HttpPost("assignrole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto registrationRequestDto)
        {
            var assignRoleSuccess = await _authService.AssignRole(registrationRequestDto.Email, registrationRequestDto.Role);
            if (!assignRoleSuccess)
            {
                _response.IsSuccess = false;
                _response.Message = "Error al asignar el rol.";
                return BadRequest(_response);
            }

            _response.Message = "Rol asignado con éxito.";
            return Ok(_response);

        }

    }
}
