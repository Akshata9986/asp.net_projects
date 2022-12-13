using ASP.NetEmpty3.Model;
using ASP.NetEmpty3.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreempty.controller
{
    [Route("[Controller]")]
    public class HomeController : Controller {
        public IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        [Route("")]
       

        [Route("[Action]")]
        [Route("Index/{id?}")]
        public string Index(int?id) {
            return _employeeRepository.GetEmployee(id??1).name;
        }

        //[Route("~/")]
        [Route("Details/{id?}")]
        public ViewResult Details(int?id) {
            HomeDetailsViewModel homeEmployeeDetails = new HomeDetailsViewModel() {
                //Employee modal=_employeeRepository.GetEmployee(2);
                //// ViewData["Employee"]=modal;
                //ViewData["Title"] = "Details Of Employee";
                //return View(modal);
                Employee = _employeeRepository.GetEmployee(id??2),
                Title = "Details of Employee"
            };
            if (homeEmployeeDetails.Employee == null)
            {
                return View("ErrorPage");
            }
            else {
                return View(homeEmployeeDetails);
            }

            
        }

        [Route("~/")]
        [Route("Details1")]
        public IActionResult Details1() {
            var modal=_employeeRepository.GetEmployeeDetails();
            return View(modal);
        }
        //[Route("~/")]
        [Route("EnvTests")]
        public ViewResult EnvTests() {
            return View();
        }
    }


        //public ViewResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //}
       
        
        //public JsonResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //    return Json(modal);
        //}

        //public IActionResult Index() {

        //    return View()
        // }
        //public IActionResult Employee() {

        //    return View();
        //}


    
}
