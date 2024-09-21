using ApplicationLayer.Contracts;
using ApplicationLayer.DTOs;
using DomainLayer.Entities;
using InfraestructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureLayer.Implementations
{
    public class EmployeeRepository : IEmployee
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse> AddAsync(Employee employee)
        {
            var check = await _context.Employees
                .FirstOrDefaultAsync(x => x.Name.ToLower() == employee.Name.ToLower());

            if(check != null)
            {
                return new ServiceResponse(false, "Employee already exists");
            }
            _context.Employees.Add(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Employee added successfully");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return new ServiceResponse(false, "Employee not found");
            }

            _context.Employees.Remove(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Employee deleted successfully");

        }

        public async Task<List<Employee>> GetAllAsync() => await _context.Employees.AsNoTracking().ToListAsync();


        public async Task<Employee> GetByIdAsync(int id) => await _context.Employees.FindAsync(id);

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Employee updated successfully");
        }

        private async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
