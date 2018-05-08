using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Student_System
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        public decimal grade { get; set; }

        public Student(string name, int age, decimal grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public override string ToString()
        {
            string gradeStr = "";
            if (grade >= 5m)
            {
                gradeStr = "Excellent";
            }
            else if (grade >= 3.50m)
            {
                gradeStr = "Average";
            }
            else
            {
                gradeStr = "Very nice person.";
                return $"{this.name} is {this.age} years old. {gradeStr}";
            }
            return $"{this.name} is {this.age} years old. {gradeStr} student.";
        }
    }
}
