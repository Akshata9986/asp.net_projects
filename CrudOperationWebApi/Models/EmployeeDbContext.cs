using Microsoft.EntityFrameworkCore;

namespace CrudOperationWebApi.Models {
    public class EmployeeDbContext : DbContext{

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { 

        }
        //only one type is present in our project as of now
        public DbSet<Employee> employee { get; set; }



    }

    //in order to everide the modal class that we have
   

}
