using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Company_Roster
{
    public class Employee
    {
        public string name { get; set; }
        public double salary { get; set; }
        public string position { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public int age { get; set; }

        public Employee (string name, double salary, string position, string department, string email="n/a", int age=-1)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }

    }
}
