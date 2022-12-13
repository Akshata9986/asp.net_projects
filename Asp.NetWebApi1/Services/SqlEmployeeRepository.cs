using Asp.NetWebApi1.Model;
using Asp.NetWebApi1.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetWebApi1.Services
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext context;
        public SqlEmployeeRepository(EmployeeDbContext context)
        {
            this.context = context;
        }

        public Employee Add(Employee employee)
        {
            context.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employee.Find(id);
            if (employee != null)
            {
                context.Employee.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetEmployeeDetails()
        {
            return context.Employee;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employee.Find(id);
        }

        public Employee Update(Employee EmployeeDbContext)
        {
            var employee = context.Employee.Attach(EmployeeDbContext);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return EmployeeDbContext;

        }
    }
}
