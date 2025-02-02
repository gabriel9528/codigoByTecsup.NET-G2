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
    [Migration("20240824021408_Table_Many_To_Many_one")]
    partial class Table_Many_To_Many_one
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.StudentMateria", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("StudentMateria");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToMany.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToMany.Pattient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Pattient");
                });

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

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.EmployeeAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeeAddress");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.StudentMateria", b =>
                {
                    b.HasOne("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.Materia", "Materia")
                        .WithMany("StudentMaterias")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.Student", "Student")
                        .WithMany("StudentMaterias")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToMany.Pattient", b =>
                {
                    b.HasOne("RelationsUsingFLUENT_API.Models.OneToMany.Doctor", "Doctor")
                        .WithMany("PattientsList")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
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

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.EmployeeAddress", b =>
                {
                    b.HasOne("RelationsUsingFLUENT_API.Models.OneToOne.Employee", "Employee")
                        .WithOne("EmployeeAddress")
                        .HasForeignKey("RelationsUsingFLUENT_API.Models.OneToOne.EmployeeAddress", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.Materia", b =>
                {
                    b.Navigation("StudentMaterias");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1.Student", b =>
                {
                    b.Navigation("StudentMaterias");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToMany.Doctor", b =>
                {
                    b.Navigation("PattientsList");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.CarCompany", b =>
                {
                    b.Navigation("CarModel");
                });

            modelBuilder.Entity("RelationsUsingFLUENT_API.Models.OneToOne.Employee", b =>
                {
                    b.Navigation("EmployeeAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
