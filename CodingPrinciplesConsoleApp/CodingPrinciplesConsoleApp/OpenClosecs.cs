using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPrinciplesConsoleApp
{
     class OpenClosecs
    {
        public class IReportGeneration
        {
            public virtual void GenerateReport(Employee em)
            {
                // From base
            }
        }

        public class CrystalReportGeneraion : IReportGeneration
        {
            public override void GenerateReport(Employee em)
            {

            }
        }

        public class PDFReportGeneraion : IReportGeneration
        {
            public override void GenerateReport(Employee em)
            {

            }
        }

    }
}
