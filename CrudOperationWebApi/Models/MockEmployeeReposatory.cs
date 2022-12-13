using System.Collections.Generic;
using System.Linq;

namespace CrudOperationWebApi.Models {
    public class MockEmployeeReposatory : IEmployeeReposatory {


        public List<Employee> _employee = new List<Employee>();
        public MockEmployeeReposatory() {
            _employee.Add(new Employee() { Id = 1, Name = "ShANTHALA", Phone = 2343, Place = "Bangalore" });
            _employee.Add(new Employee() { Id = 2, Name = "Ramu", Phone = 4567, Place = "Mangalore" });
            _employee.Add(new Employee() { Id = 3, Name = "Shwetha", Phone = 8765, Place = "Gokarna" });
            _employee.Add(new Employee() { Id = 4, Name = "Deeksha", Phone = 5647, Place = "Vishakapatnam" });

        }

        public Employee Add(Employee employee) {
            employee.Id = _employee.Max(e => e.Id) + 1;
            _employee.Add(employee);
            return employee;
        }

        public Employee Delete(int id) {
            Employee employee = _employee.FirstOrDefault(e => e.Id == id);
            if (employee != null) {
                _employee.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee() {
            return _employee;
        }

        public Employee GetEmployee(int id) {
            return _employee.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employeeUpdated) {
            Employee employee = _employee.FirstOrDefault(e => e.Id == employeeUpdated.Id);
            if (employee != null) {
                employee.Name = employeeUpdated.Name;
                employee.Phone = employeeUpdated.Phone;
                employee.Place = employeeUpdated.Place;
            }
            return employee;
        }
    }

    }

