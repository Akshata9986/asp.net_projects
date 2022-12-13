using CodeFirstWebApiApp.Model;
using CodeFirstWebApiApp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstWebApiApp.Services
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentDbContext context;
        public SqlStudentRepository(StudentDbContext context)
        {
            this.context = context;
        }

        public Students Add(Students students)
        {
            context.Add(students);
            context.SaveChanges();
            return students;
        }

        public Students Delete(int Id)
        {
            Students students = context.Students.Find(Id);
            if (students != null)
            {
                context.Students.Remove(students);
                context.SaveChanges();
            }
            return students;
        }

        public IEnumerable<Students> GetStudentsDetails()
        {
            return context.Students;
        }

        public Students GetStudents(int Id)
        {
            return context.Students.Find(Id);
        }

        public Students Update(Students StudentDbContext)
        {
            var students = context.Students.Attach(StudentDbContext);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            students.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return StudentDbContext;

        }
    }
}
