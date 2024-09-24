using ASPNetCore_Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SearchClassLibrary.Contracts;
using SearchClassLibrary.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASPNetCore_Identity.Repositories
{
    public class UserAccount : IUserAccount
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public UserAccount(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        public async Task<ServiceResponse.GeneralResponse> CreateAccount(UserDto userDto)
        {
            if (userDto == null) return new ServiceResponse.GeneralResponse(false, "El UserDto no es valido");
            var newUser = new ApplicationUser()
            {
                Nombre = userDto.Name,
                Email = userDto.Email,
                UserName = userDto.Email,
                PasswordHash = userDto.Password
            };

            var user = await _userManager.FindByEmailAsync(userDto.Email);
            if(user is not null) return new ServiceResponse.GeneralResponse(false, "El usuario ya se encuentra registrado");

            var createUser = await _userManager.CreateAsync(newUser, userDto.Password);
            if(!createUser.Succeeded) return new ServiceResponse.GeneralResponse(false, "Ocurrio un error ....vualva a intentarlo");

            //Asignar el rol: Admin para el primer registro
            var checkAdmin = await _roleManager.FindByNameAsync("Admin");
            if(checkAdmin is null)
            {
                await _roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });
                await _userManager.AddToRoleAsync(newUser, "Admin");
                return new ServiceResponse.GeneralResponse(true, "Usuario Admin creado exitosamente");
            }
            else
            {
                var checkUser = await _roleManager.FindByNameAsync("User");
                if (checkUser is null)
                {
                    await _roleManager.CreateAsync(new IdentityRole() { Name = "User" });
                }
                await _userManager.AddToRoleAsync(newUser, "User");
                return new ServiceResponse.GeneralResponse(true, "Usuario User creado exitosamente");
            }
        }

        public async Task<ServiceResponse.LoginResponse> LoginAccount(LoginDto loginDto)
        {
            if(loginDto == null) return new ServiceResponse.LoginResponse(false, null!, "El LoginDto no es valido");

            var getUser = await _userManager.FindByEmailAsync(loginDto.Email);
            if(getUser is null) return new ServiceResponse.LoginResponse(false, null!, "El usuario no se encuentra registrado");

            var checkPassword = await _userManager.CheckPasswordAsync(getUser, loginDto.Password);
            if(!checkPassword) return new ServiceResponse.LoginResponse(false, null!, "El usuario o La contraseña es incorrecta");

            var getUserRole = await _userManager.GetRolesAsync(getUser);
            var userSession = new UserSession(getUser.Id, getUser.Nombre, getUser.Email, getUserRole.First());

            var token = GenerateToken(userSession);
            return new ServiceResponse.LoginResponse(true, token, "Login exitoso");
        }


        private string GenerateToken(UserSession userSession)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var userClaims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userSession.Id),
                new Claim(ClaimTypes.Name, userSession.Name),
                new Claim(ClaimTypes.Email, userSession.Email),
                new Claim(ClaimTypes.Role, userSession.Role)
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: userClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
