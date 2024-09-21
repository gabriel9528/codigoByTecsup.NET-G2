using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using ApplicationLayer.DTOs;
using DomainLayer.Entities;
using ApplicationLayer.Service;

public class EmployeeServicesTests
{
    private readonly Mock<HttpMessageHandler> _handlerMock;
    private readonly HttpClient _httpClient;
    private readonly EmployeeServices _employeeService;

    public EmployeeServicesTests()
    {
        _handlerMock = new Mock<HttpMessageHandler>();
        _httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri("http://localhost") // URL base falsa
        };
        _employeeService = new EmployeeServices(_httpClient);
    }

    [Fact]
    public async Task AddAsync_ReturnsSuccessfulServiceResponse()
    {
        // Arrange
        var employee = new Employee { Id = 1, Name = "John Doe", Address = "123 Main St" };
        var expectedResponse = new ServiceResponse(true, "Employee added successfully");

        //Configuracion del mock para el metodo SendAsync
        //_handlerMock.Protected(): Permite acceder a los métodos protegidos en HttpMessageHandler,
        //como SendAsync, que normalmente no están accesibles.
        _handlerMock
            .Protected()
            //Setup<Task<HttpResponseMessage>>("SendAsync", ...): Configura el mock para que el método
            //SendAsync devuelva un HttpResponseMessage simulado.
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                //ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post):
                //Especifica que la configuración solo debe aplicarse a solicitudes POST.
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post),
                //ItExpr.IsAny<CancellationToken>(): Indica que no se debe aplicar ninguna
                //restricción al token de cancelación.
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = JsonContent.Create(expectedResponse)
            });

        // Act
        var result = await _employeeService.AddAsync(employee);

        // Assert
        result.Should().BeEquivalentTo(expectedResponse);
    }

    [Fact]
    public async Task AddAsync_ReturnsErrorServiceResponseOnFailure()
    {
        // Arrange
        var employee = new Employee { Id = 1, Name = "John Doe", Address = "123 Main St" };

        _handlerMock
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post),
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.InternalServerError // Simular error del servidor
            });

        // Act
        var result = await _employeeService.AddAsync(employee);

        // Assert
        result.Flag.Should().BeFalse();
        result.Message.Should().Be("Error in response from server.");
    }
}
