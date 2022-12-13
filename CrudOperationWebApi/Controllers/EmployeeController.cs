using Microsoft.AspNetCore.Mvc;

namespace CrudOperationWebApi.Controllers {
    public class EmployeeController : Controller {

        public EmployeeController _employeeRepository;
        [HttpGet]
        public int test() {
            return 20;
        }
    }
}
