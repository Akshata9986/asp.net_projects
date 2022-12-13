using CodeFirstWebApiApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstWebApiApp.Repo
{
   public interface IStudentRepository
    {
        Students GetStudents(int Id);

        public IEnumerable<Students> GetStudentsDetails();

        Students Add(Students students);
        Students Update(Students students);
        Students Delete(int Id);
    }
}
