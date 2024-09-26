using Microsoft.AspNetCore.Identity;

namespace ASPNetCore_Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
    }
}
