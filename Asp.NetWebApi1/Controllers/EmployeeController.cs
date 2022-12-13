using Asp.NetWebApi1.Model;
using Asp.NetWebApi1.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetWebApi1.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        [HttpGet]
        [Route("Test/Get")]
        public int test()
        {
            return 20;
        }


        [HttpGet]
        [Route("Employee/Get")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployeeDetails();
        }



        [HttpGet]
        [Route("Employee/Get/{id}")]
        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployee(id);
        }


        [HttpPost]
        [Route("Employee/Post")]
        public Employee AddEmployee(Employee employee)
        {
            var newemployee = _employeeRepository.Add(employee);
            return (newemployee);
        }

        [HttpDelete]
        [Route("Employee/Delete/{id}")]
        public Employee DeleteEmployee(int id)
        {
            var delemployee = _employeeRepository.Delete(id);
            return (delemployee);
        }
    }
}

