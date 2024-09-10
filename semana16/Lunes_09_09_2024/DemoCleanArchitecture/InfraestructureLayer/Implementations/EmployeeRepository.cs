using ApplicationLayer.DTOs;
using ApplicationLayer.Interfaces;
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
            var response = await _context.Employees
                .FirstOrDefaultAsync(x => x.Name.ToLower() == employee.Name.ToLower());

            if (response != null)
            {
                return new ServiceResponse(false, "El empleado ya existe");
            }

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return new ServiceResponse(true, "Empleado guardado exitosamente");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee == null)
                return new ServiceResponse(false, "No se encontro el empleado a eliminar");

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return new ServiceResponse(true, "Empleado eliminado exitosamente");
        }

        public async Task<List<Employee>> GetAllAsync() => await _context.Employees.AsNoTracking().ToListAsync();

        public async Task<Employee> GetByIdAsync(int id) => await _context.Employees.FindAsync(id);

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();

            return new ServiceResponse(true, "Empleado actualziado exitosamente");
        }
    }
}
