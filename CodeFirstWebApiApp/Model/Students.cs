using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstWebApiApp.Model
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int age { get; set; }
    }
}
