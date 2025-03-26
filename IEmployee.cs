using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfaceAndAbstractClass.Enum;

namespace InterfaceAndAbstractClass
{
    internal interface IEmployee
    {
        string Name { get; set; }
        string? EmployeeType { get; set; }
        string? Role { get; set; }
        int TotalExp { get; set; }
        string GetEmployeeDetails();
    }
}
