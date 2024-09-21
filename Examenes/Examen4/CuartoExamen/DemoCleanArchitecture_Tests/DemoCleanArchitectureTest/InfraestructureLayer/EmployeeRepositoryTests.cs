using DomainLayer.Entities;
using FluentAssertions;
using InfraestructureLayer.Data;
using InfraestructureLayer.Implementations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCleanArchitectureTest.InfraestructureLayer
{
    public class EmployeeRepositoryTests
    {
        // Método para configurar una base de datos en memoria
        private async Task<AppDbContext> GetDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var dbContext = new AppDbContext(options);
            dbContext.Database.EnsureCreated();

            // Si deseas insertar datos de ejemplo
            if (await dbContext.Employees.CountAsync() == 0)
            {
                dbContext.Employees.AddRange(new List<Employee>
                {
                    new Employee { Name = "John Doe", Address = "123 Main St" },
                    new Employee { Name = "Jane Doe", Address = "456 Elm St" }
                });
                await dbContext.SaveChangesAsync();
            }

            return dbContext;
        }

        [Fact]
        public async Task EmployeeRepository_AddAsync_ReturnsSuccess()
        {
            // Arrange
            var employee = new Employee { Name = "New Employee", Address = "789 Pine St" };
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            // Act
            var result = await employeeRepository.AddAsync(employee);

            // Assert
            result.Flag.Should().BeTrue();
            result.Message.Should().Be("Employee added successfully");
        }

        [Fact]
        public async Task EmployeeRepository_AddAsync_EmployeeAlreadyExists_ReturnsFailure()
        {
            // Arrange
            var employee = new Employee { Name = "John Doe", Address = "123 Main St" }; // Ya existe "John Doe" en la base de datos
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            // Act
            var result = await employeeRepository.AddAsync(employee);

            // Assert
            result.Flag.Should().BeFalse(); // Verifica el flag del ServiceResponse
            result.Message.Should().Be("Employee already exists");
        }

        [Fact]
        public async Task EmployeeRepository_GetByIdAsync_ReturnsEmployee()
        {
            // Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            // Act
            var employee = await employeeRepository.GetByIdAsync(1);

            // Assert
            employee.Should().NotBeNull();
            employee.Name.Should().Be("John Doe");
            employee.Address.Should().Be("123 Main St");
        }

        [Fact]
        public async Task EmployeeRepository_GetAllAsync_ReturnsEmployeeList()
        {
            // Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            // Act
            var employees = await employeeRepository.GetAllAsync();

            // Assert
            employees.Should().HaveCount(2);
        }

        [Fact]
        public async Task EmployeeRepository_UpdateAsync_ReturnsSuccess()
        {
            // Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);
            var employee = await employeeRepository.GetByIdAsync(1);
            employee.Address = "Updated Address";

            // Act
            var result = await employeeRepository.UpdateAsync(employee);

            // Assert
            result.Flag.Should().BeTrue(); // Verifica el flag del ServiceResponse
            result.Message.Should().Be("Employee updated successfully");
        }

        [Fact]
        public async Task EmployeeRepository_DeleteAsync_ReturnsSuccess()
        {
            // Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            // Act
            var result = await employeeRepository.DeleteAsync(1);

            // Assert
            result.Flag.Should().BeTrue(); // Verifica el flag del ServiceResponse
            result.Message.Should().Be("Employee deleted successfully");
        }
    }
}
