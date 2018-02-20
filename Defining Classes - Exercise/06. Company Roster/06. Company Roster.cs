using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                string[] emp = Console.ReadLine()
                                .Split()
                                .ToArray();
                if (emp.Count() == 6)
                {
                    Employee newEmp = new Employee(emp[0], double.Parse(emp[1]), emp[2], emp[3], emp[4], int.Parse(emp[5]));
                    employees.Add(newEmp);
                }
                else if (emp.Count() == 5)
                {
                    Employee newEmp = new Employee(emp[0], double.Parse(emp[1]), emp[2], emp[3], emp[4]);
                    employees.Add(newEmp);   
                }
                else if (emp.Count() == 4)
                {
                    Employee newEmp = new Employee(emp[0], double.Parse(emp[1]), emp[2], emp[3]);
                    employees.Add(newEmp);
                }


            }

            var highestAverageSalaryDepartment = employees
                .GroupBy(e => e.department)
                .OrderByDescending(g => g.Select(e => e.salary).Sum())
                .First();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");
            Console.WriteLine(string.Join(Environment.NewLine, highestAverageSalaryDepartment
                .OrderByDescending(e => e.salary)
                .Select(e => $"{e.name} {e.salary:F2} {e.email} {e.age}")));


        }
    }
}
