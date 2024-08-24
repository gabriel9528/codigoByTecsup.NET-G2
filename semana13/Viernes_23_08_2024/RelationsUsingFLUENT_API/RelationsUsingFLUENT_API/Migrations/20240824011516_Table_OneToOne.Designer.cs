﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelationsUsingFLUENT_API.Data;

#nullable disable

namespace RelationsUsingFLUENT_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240824011516_Table_OneToOne")]
    partial class Table_OneToOne
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.CarCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarCompany");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarCompanyId")
                        .IsUnique();

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.CarModel", b =>
                {
                    b.HasOne("RelationsUsingFLUENT_API.Models.OneToOne.CarCompany", "CarCompany")
                        .WithOne("CarModel")
                        .HasForeignKey("RelationsUsingFLUENT_API.Models.OneToOne.CarModel", "CarCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarCompany");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.CarCompany", b =>
                {
                    b.Navigation("CarModel");
                });
#pragma warning restore 612, 618
        }
    }
}
