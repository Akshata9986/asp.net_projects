using Asp.NetWebApi1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetWebApi1.Repo
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        public IEnumerable<Employee> GetEmployeeDetails();

        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);

    }
}
