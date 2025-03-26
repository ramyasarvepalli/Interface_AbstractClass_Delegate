using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee() 
        {
            EmployeeType = "FullTime";
        }
        public required int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
