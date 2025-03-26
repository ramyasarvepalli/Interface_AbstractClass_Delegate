using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceAndAbstractClass
{
    internal class Program
    {
        public class Promotion
        {
            public int count { get; set; }
            public int total = 0;
            public bool IsPromotableMethod(int totalExp)
            {
                return (totalExp != 0 && totalExp > 5) ? true : false;
            }
            public int EmployeesPromotedCount(Employee.IsPromotableDelegate isPromotableDelegate, List<Employee> employee)
            {
                foreach (Employee emp in employee)
                {
                    count = isPromotableDelegate(emp.TotalExp) == true ? 1 : 0;
                    total = total + count;
                }
                return total;
            }

        }
        public static void Main(string[] args)
        {
            //Employee emp = new FullTimeEmployee()
            //{
            //    Name = "Ramya",
            //    Role = "TL",
            //    TotalExp = 3,
            //    AnnualSalary = 600000
            //};

            //Console.WriteLine(emp.GetEmployeeDetails());
            //Console.WriteLine($"Monthly salary is: {emp.GetMonthlySalary()}");
            //emp.isPromotableDelegate = emp.IsPromotable;

            //Console.WriteLine($"Is {emp.Name} promotable?: {emp.isPromotableDelegate(emp.TotalExp)}");

            List<Employee> fullTimeEmployees = [
                new FullTimeEmployee {Name = "Ramya",Role = "TL", TotalExp = 3, AnnualSalary = 600000},
                new FullTimeEmployee {Name = "Ramya1",Role = "TL1", TotalExp = 4, AnnualSalary = 800000},
                new FullTimeEmployee {Name = "Ramya2",Role = "TL2", TotalExp = 6, AnnualSalary = 1000000},
                new FullTimeEmployee {Name = "Ramya3",Role = "TL3", TotalExp = 2, AnnualSalary = 400000},
                new FullTimeEmployee {Name = "Ramya4",Role = "TL4", TotalExp = 11, AnnualSalary = 2000000}
                ];

            foreach(Employee emp in fullTimeEmployees) {
                Console.WriteLine(emp.GetEmployeeDetails());
                Console.WriteLine($"Monthly salary is: {emp.GetMonthlySalary()}");
                emp.isPromotableDelegate = emp.IsPromotable;
                Console.WriteLine($"Is {emp.Name} promotable?: {emp.isPromotableDelegate(emp.TotalExp)}"); //callback
            }
            Console.WriteLine();

            int count = fullTimeEmployees.Count(emp => emp.TotalExp > 3);
            Console.WriteLine($"Employees more than 3 years of exp: {count}");

            

            Promotion clr = new Promotion();
            int promotedCount = clr.EmployeesPromotedCount(clr.IsPromotableMethod, fullTimeEmployees);
            Console.WriteLine($"No.of employees promoted: {promotedCount}");
            //Employee contractEmployee = new ContractEmployee()
            //{
            //    Name = "Ram",
            //    Role = "Manager",
            //    TotalExp = 10,
            //    NoOfHoursWorked = 16
            //};

            //Console.WriteLine(contractEmployee.GetEmployeeDetails());
            //Console.WriteLine($"Monthly salary is: {contractEmployee.GetMonthlySalary()}");
            //Console.WriteLine($"Is {contractEmployee.Name} promotable?: {contractEmployee.isPromotableDelegate(contractEmployee.TotalExp)}");


        }
    }
}
