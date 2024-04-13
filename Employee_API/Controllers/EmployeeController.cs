using Microsoft.AspNetCore.Mvc;
using Employee_API.Models;
using System.Collections.Generic;

namespace Employee_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>();

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employees;
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employees.Find(emp => emp.Id == id);
        }

        [HttpPost]
        public void Post(Employee employee)
        {
            _employees.Add(employee);
        }

        [HttpPut("{id}")]
        public void Put(int id, Employee employee)
        {
            int index = _employees.FindIndex(emp => emp.Id == id);
            if (index != -1)
            {
                _employees[index] = employee;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employees.RemoveAll(emp => emp.Id == id);
        }
    }
}
