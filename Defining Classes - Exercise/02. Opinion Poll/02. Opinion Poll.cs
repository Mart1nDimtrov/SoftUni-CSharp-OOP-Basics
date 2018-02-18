using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                string[] member = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                people.Add(new Person(member[0], int.Parse(member[1])));
            }

            people.Where(p => p.Age > 30)
                  .OrderBy(p => p.Name)
                  .ToList()
                  .ForEach(p => Console.WriteLine(p));

        }
    }
}
