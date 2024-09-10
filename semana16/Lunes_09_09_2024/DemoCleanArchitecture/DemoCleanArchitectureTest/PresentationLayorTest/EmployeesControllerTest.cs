using ApplicationLayer.DTOs;
using ApplicationLayer.Interfaces;
using DomainLayer.Entities;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Controllers;

namespace DemoCleanArchitectureTest.PresentationLayorTest
{
    public class EmployeesControllerTest
    {
        private EmployeesController _employeesController;
        private IEmployee _employeeService;

        public EmployeesControllerTest()
        {
            //Configuracion FakeItEasy para simular el servicio de empleados
            _employeeService = A.Fake<IEmployee>();
            _employeesController = new EmployeesController(_employeeService);
        }

        [Fact]
        public async Task EmployeeController_GetAll_ReturnsOkEmployeesList()
        {
            //Arrange
            var employees = A.Fake<List<Employee>>();
            A.CallTo(() => _employeeService.GetAllAsync()).Returns(Task.FromResult(employees));

            //Act
            var result = await _employeesController.GetAll();

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(employees);
        }

        [Fact]
        public async Task EmployeesController_GetById_ReturnsOkEmployee()
        {
            //Arrange
            int id = 1;
            var employee = A.Fake<Employee>();
            A.CallTo(()=>_employeeService.GetByIdAsync(id)).Returns(employee);

            //Act
            var result = await _employeesController.GetById(id);

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(employee);
        }

        [Fact]
        public async Task EmployeeController_GetById_ReturnsNotFoundEmployee()
        {
            //Arrange
            int id = 1;
            A.CallTo(() => _employeeService.GetByIdAsync(id)).Returns(null as Employee);

            //Act
            var result = await _employeesController.GetById(id);

            //Assert
            result.Should().BeOfType<NotFoundResult>();
        }


        [Fact]
        public async Task EmployeeController_AddEmployee_ReturnsOkResponse()
        {
            //Arrange
            var employee = new Employee { Name = "Juancito", Address = "calle coopertaiva 123" };
            var serviceResponse = new ServiceResponse ( true, "Empleado guardado exitosamente" );
            A.CallTo(() => _employeeService.AddAsync(employee)).Returns(serviceResponse);

            //Act
            var result = await _employeesController.AddEmployee(employee);

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(serviceResponse);

        }

        [Fact]
        public async Task EmployeeController_UpdateEmployee_ReturnsOkResponse()
        {
            //Arrange
            var employee = new Employee { Id = 1, Name = "Pedrito", Address = "calle 123" };
            var serviceResponse = new ServiceResponse(true, "Empleado actualziado exitosamente");
            A.CallTo(() => _employeeService.UpdateAsync(employee)).Returns(serviceResponse);

            //Act
            var result = await _employeesController.UpdateEmployee(employee);

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(serviceResponse);

        }

        [Fact]
        public async Task EmployeeController_DeleteEmployee_ReturnsOkResponse()
        {
            //Arrange
            int id = 1;
            var serviceResponse = new ServiceResponse(true, "Empleado eliminado exitosamente");
            A.CallTo(()=> _employeeService.DeleteAsync(id)).Returns(serviceResponse);

            //Act
            var result = await _employeesController.DeleteEmployee(id);

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult.Value.Should().Be(serviceResponse);

        }

    }
}
