using DomainLayer.Entities;
using FluentAssertions;
using InfraestructureLayer.Data;
using InfraestructureLayer.Implementations;
using Microsoft.EntityFrameworkCore;

namespace DemoCleanArchitectureTest.InfraestructureLayerTest
{
    public class EmployeeRepositoryTests
    {
        //Metodo para configurar la base de datos en memoria
        private async Task<AppDbContext> GetDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var dbContext = new AppDbContext(options);
            dbContext.Database.EnsureCreated();

            //Si deseamos se agregan datos -> Seed(Siembra de datos)
            if (await dbContext.Employees.CountAsync() == 0)
            {
                dbContext.Employees.AddRange(new List<Employee>
                {
                    new Employee { Name = "Juan", Address = "Calle nueva 600" },
                    new Employee { Name = "Gabriel", Address = "Avenida circunvalacion 300" },
                    new Employee { Name = "Andrea", Address = "Calle Trinidad 400" }
                });
                await dbContext.SaveChangesAsync();
            }
            return dbContext;
        }

        [Fact]
        public async Task EmployeeRepository_AddAsync_ReturnsSuccess()
        {
            //Arrange
            var employee = new Employee { Name = "Pedro", Address = "Calle 100" };
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            //Act
            var result = await employeeRepository.AddAsync(employee);

            //Assert
            result.Flag.Should().BeTrue();
            result.Message.Should().Be("Empleado guardado exitosamente");
        }

        [Fact]
        public async Task EmployeeRepository_AddAsync_ReturnsFaillurer()
        {
            //Arrange
            var employee = new Employee { Name = "Juan", Address = "Calle nueva 600" };
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            //Act
            var result = await employeeRepository.AddAsync(employee);

            //Assert
            result.Flag.Should().BeFalse();
            result.Message.Should().Be("El empleado ya existe");
        }

        [Fact] 
        public async Task EmployeeRepository_GetById_ReturnsEmployee()
        {
            //Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            //Act
            var result = await employeeRepository.GetByIdAsync(2);

            //Assert
            result.Should().NotBeNull();
            result.Name.Should().Be("Gabriel");
            result.Address.Should().Be("Avenida circunvalacion 300");
        }

        [Fact]
        public async Task EmployeeRepository_GetAll_ReturnsEmployeesList()
        {
            //Arange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            //Act
            var result = employeeRepository.GetAllAsync();

            //Assert
            result.Should().BeOfType<Task<List<Employee>>>();
        }

        [Fact]
        public async Task EmployeeRepository_UpdateAsync_ReturnSucces()
        {
            //Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);
            var employee = await employeeRepository.GetByIdAsync(1);
            employee.Address = "avenidad Santo Thomas 150";

            //Act
            var result = await employeeRepository.UpdateAsync(employee);

            //Assert
            result.Flag.Should().BeTrue();
            result.Message.Should().Be("Empleado actualziado exitosamente");

        }

        [Fact]
        public async Task EmployeeRepository_DeleteAsync_ReturnSucces()
        {
            //Arrange
            var dbContext = await GetDbContext();
            var employeeRepository = new EmployeeRepository(dbContext);

            //Act
            var result = await employeeRepository.DeleteAsync(1);

            //Assert
            result.Flag.Should().BeTrue();
            result.Message.Should().Be("Empleado eliminado exitosamente");
        }


    }
}
