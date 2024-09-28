using Microsoft.AspNetCore.Identity;

namespace Microservicios.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombres { get; set; }
    }
}
