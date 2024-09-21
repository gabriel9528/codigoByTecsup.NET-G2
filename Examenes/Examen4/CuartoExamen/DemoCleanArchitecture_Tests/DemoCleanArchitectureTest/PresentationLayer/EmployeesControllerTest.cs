using ApplicationLayer.Contracts;
using ApplicationLayer.DTOs;
using ApplicationLayer.Service;
using DomainLayer.Entities;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbAPI.Controllers;

namespace DemoCleanArchitectureTest.PresentationLayer
{
    public class EmployeesControllerTest
    {
        private EmployeesController _employeesController;
        private IEmployee _employeeService;

        public EmployeesControllerTest()
        {
            // Configurar FakeItEasy para simular el servicio de empleados
            _employeeService = A.Fake<IEmployee>();
            _employeesController = new EmployeesController(_employeeService);
        }

        [Fact]
        public async Task EmployeesController_Get_ReturnsOkWithEmployees()
        {
            // Arrange
            var employees = A.Fake<List<Employee>>();  
            A.CallTo(() => _employeeService.GetAllAsync()).Returns(Task.FromResult(employees));  

            // Act
            var result = await _employeesController.Get();

            // Assert
            result.Should().BeOfType<OkObjectResult>();  // Verifica que la respuesta sea un 200 OK
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(employees);  // Verifica que el contenido de la respuesta sea la lista de empleados
        }

        [Fact]
        public async Task EmployeesController_GetById_ReturnsOkWithEmployee()
        {
            // Arrange
            int id = 1;
            var employee = A.Fake<Employee>();
            A.CallTo(() => _employeeService.GetByIdAsync(id)).Returns(employee);

            // Act
            var result = await _employeesController.Get(id);

            // Assert
            result.Should().BeOfType<OkObjectResult>();  // Verifica que la respuesta sea un 200 OK
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(employee);  // Verifica que el contenido sea el empleado obtenido
        }

        [Fact]
        public async Task EmployeesController_GetById_ReturnsNotFoundIfEmployeeNotExists()
        {
            // Arrange
            int id = 1;
            A.CallTo(() => _employeeService.GetByIdAsync(id)).Returns(null as Employee);  // Simula que no existe el empleado

            // Act
            var result = await _employeesController.Get(id);

            // Assert
            result.Should().BeOfType<NotFoundResult>();  // Verifica que la respuesta sea un 404 Not Found
        }

        [Fact]
        public async Task EmployeesController_Post_ReturnsOkWithResponse()
        {
            // Arrange
            var employee = new Employee { Name = "New Employee", Address = "123 Main St" };
            var serviceResponse = new ServiceResponse(true, "Employee added successfully");
            A.CallTo(() => _employeeService.AddAsync(employee)).Returns(serviceResponse);

            // Act
            var result = await _employeesController.Post(employee);

            // Assert
            result.Should().BeOfType<OkObjectResult>();  // Verifica que la respuesta sea un 200 OK
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(serviceResponse);  // Verifica que el contenido sea el ServiceResponse devuelto
        }

        [Fact]
        public async Task EmployeesController_Put_ReturnsOkWithResponse()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "Updated Employee", Address = "456 Elm St" };
            var serviceResponse = new ServiceResponse(true, "Employee updated successfully");
            A.CallTo(() => _employeeService.UpdateAsync(employee)).Returns(serviceResponse);

            // Act
            var result = await _employeesController.Put(employee);

            // Assert
            result.Should().BeOfType<OkObjectResult>();  // Verifica que la respuesta sea un 200 OK
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(serviceResponse);  // Verifica que el contenido sea el ServiceResponse devuelto
        }

        [Fact]
        public async Task EmployeesController_Delete_ReturnsOkWithResponse()
        {
            // Arrange
            int id = 1;
            var serviceResponse = new ServiceResponse(true, "Employee deleted successfully");
            A.CallTo(() => _employeeService.DeleteAsync(id)).Returns(serviceResponse);

            // Act
            var result = await _employeesController.Delete(id);

            // Assert
            result.Should().BeOfType<OkObjectResult>();  // Verifica que la respuesta sea un 200 OK
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(serviceResponse);  // Verifica que el contenido sea el ServiceResponse devuelto
        }
    }
}
