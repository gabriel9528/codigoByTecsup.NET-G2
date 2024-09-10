using ApplicationLayer.Interfaces;
using DomainLayer.Entities;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
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
        public async Task EmployeesRepository_GetById_ReturnsOkEmployee()
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
    }
}
