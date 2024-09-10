using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstDemo.Data;

public partial class Prueba1Context : DbContext
{
    public Prueba1Context()
    {
    }

    public Prueba1Context(DbContextOptions<Prueba1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
