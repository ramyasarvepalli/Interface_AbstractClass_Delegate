using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    internal abstract class Employee : IEmployee
    {
        public required string Name { get; set; }
        public string? EmployeeType { get; set; }
        public string? Role { get; set; }
        public int TotalExp { get; set; }
      
        public bool IsPromotable(int totalExp) 
        {
            return (totalExp != 0 && totalExp > 5) ? true : false;
        }

        public delegate bool IsPromotableDelegate(int totalExp);
        public IsPromotableDelegate? isPromotableDelegate;

        //public int EmployeesPromotedCount(IsPromotableDelegate isPromotableDelegate, List<Employee> employee)
        //{
        //    foreach(Employee emp in employee)
        //    {
        //        count = isPromotableDelegate(emp.TotalExp) == true ? 1 : 0;
        //        total = total + count;
        //    }
        //    return total;
        //}

        public string GetEmployeeDetails()
        {
            return $"Name: {Name}, EmployeeType: {EmployeeType}, Role: {Role}, Total years of experience: {TotalExp}";
        }
        public abstract int GetMonthlySalary();
       
    }
}