using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPrinciplesConsoleApp
{
    class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public bool InsertIntoEmployeeTable(Employee em)
        {
            return true;
        }

        public void GenerateReport(Employee em)
        {

        }
    }

    //public class ReportGeneration
    //{
    //    public void GenerateReport(Employee em)
    //    {
            
    //    }
    //}

   
      
}



