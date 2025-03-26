using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    internal class ContractEmployee : Employee
    {
        public int HourlyPay {  get; set; }
        public required int NoOfHoursWorked { get; set; }
        public ContractEmployee() 
        {
            EmployeeType = "Contract";
            HourlyPay = 2000;
        }
        public override int GetMonthlySalary()
        {
            return NoOfHoursWorked * HourlyPay;   
        }
    }
}
