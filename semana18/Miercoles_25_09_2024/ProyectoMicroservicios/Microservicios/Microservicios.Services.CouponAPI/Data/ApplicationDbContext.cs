using Microservicios.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservicios.Services.CouponAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Coupon> Coupon { get; set; }
    }
}
