﻿using Microservicios.Services.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservicios.Services.ShoppingCartAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
    }
}
