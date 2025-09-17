using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndActions.clasess
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal MontlhySalary { get; set; }

        public Employee(string name, string department, decimal montlhySalary)
        {
            Name = name;
            Department = department;
            MontlhySalary = montlhySalary;
        }
    }
}
