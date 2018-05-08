using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Student_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine()
                            .Split()
                            .ToArray();
            List<Student> students = new List<Student>();
            while (inp[0] != "Exit")
            {
                if (inp[0] == "Create")
                {
                    students.Add(new Student(inp[1], int.Parse(inp[2]), decimal.Parse(inp[3])));
                }
                else if (inp[0] == "Show")
                {
                    Console.WriteLine(students.Where(s => s.name == inp[1])
                                        .FirstOrDefault()
                                        .ToString()); 
                }
                inp = Console.ReadLine()
                            .Split()
                            .ToArray();
            }

        }
    }
}
