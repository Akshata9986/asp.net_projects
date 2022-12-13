using CodeFirstWebApiApp.Model;
using CodeFirstWebApiApp.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace CodeFirstWebApiApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]
    [Route("[Controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }
        [HttpGet]
        [Route("Test/Get")]
        public int test()
        {
            return 20;
        }


        [HttpGet]
        [Route("Student/Get")]
        //[DisableCors]
        public IEnumerable<Students> GetAllstudent()
        {
            return _studentRepository.GetStudentsDetails();
        }



        [HttpGet]
        [Route("Student/Get/{Id}")]
        public Students GetStudentById(int Id)
        {
            return _studentRepository.GetStudents(Id);
        }


        [HttpPost]
        [Route("Student/Post")]
        public Students AddStudents(Students students)
        {
            var newstudents = _studentRepository.Add(students);
            return (newstudents);
        }

        [HttpDelete]
        [Route("Student/Delete/{Id}")]
        public Students DeleteEmployee(int Id)
        {
            var delstudent = _studentRepository.Delete(Id);
            return (delstudent);
        }
    }
}
