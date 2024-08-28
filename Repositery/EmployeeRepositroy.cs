using CrudOperationAPIwithAngular.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationAPIwithAngular.Repositery
{
    public class EmployeeRepositroy
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepositroy(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee employee)
        {
            await db.Employees.AddAsync(employee);
            await db.SaveChangesAsync();
        }

        public async Task updateEmployee(int id, Employee obj)
        {
            var emp = await db.Employees.FindAsync(id);
            if (emp == null)
            {
                throw new Exception("Employee not found");
            }
            emp.Name = obj.Name;
            emp.Email = obj.Email;
            emp.Mobile = obj.Mobile;
            emp.Age = obj.Age;
            emp.Salary = obj.Salary;
            emp.status = obj.status;

            await db.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var emp = await db.Employees.FindAsync(id);
            if (emp == null) 
            {
                throw new Exception("Employee not found");
            }
            db.Employees.Remove(emp);
            await db.SaveChangesAsync();
        }
    }
}
