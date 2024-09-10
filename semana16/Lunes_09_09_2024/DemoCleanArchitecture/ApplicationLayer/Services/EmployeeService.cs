using ApplicationLayer.DTOs;
using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse> AddAsync(Employee employee)
        {
            try
            {
                var data = await _httpClient.PostAsJsonAsync("api/Employees", employee);
                if (data.IsSuccessStatusCode)
                {
                    var response = await data.Content.ReadFromJsonAsync<ServiceResponse>();
                    return response;
                }
                else
                {
                    return new ServiceResponse(false, "Error al guardar el empleado");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResponse(false, $"Execption: {ex.Message}");
            }
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var data = await _httpClient.DeleteAsync($"api/Employees/{id}");
            var response = await data.Content.ReadFromJsonAsync<ServiceResponse>();
            return response;
        }

        public async Task<List<Employee>> GetAllAsync() => 
            await _httpClient.GetFromJsonAsync<List<Employee>>("api/Employees");

        public async Task<Employee> GetByIdAsync(int id) =>
            await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            var data = await _httpClient.PutAsJsonAsync($"api/Employees", employee);
            var response = await data.Content.ReadFromJsonAsync<ServiceResponse>();
            return response;
        }
    }
}
