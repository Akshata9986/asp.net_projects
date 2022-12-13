using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrudOperationWebApi.Models {
    public interface IEmployeeReposatory {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);
    }
}
