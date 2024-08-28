using CrudOperationAPIwithAngular.Model;
using CrudOperationAPIwithAngular.Repositery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperationAPIwithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepositroy employee;

        public EmployeeController(EmployeeRepositroy employeeRepositroy)
        {
            this.employee = employeeRepositroy;
        }

        [HttpGet]
        public async Task<ActionResult> EmployeeList()
        {
            var allEmployee = await employee.GetEmployees();
            return Ok(allEmployee);
        }
        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee emp)
        {
            await employee.SaveEmployee(emp);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateEmployee(int id, [FromBody] Employee vm)
        {
            await employee.updateEmployee(id, vm);
            return Ok(employee);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            await employee.DeleteEmployee(id);
            return Ok(employee);
        }
    }
}
