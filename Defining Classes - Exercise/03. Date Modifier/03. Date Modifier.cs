using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            DateModifier dm = new DateModifier(first, second);
            Console.WriteLine(dm.DateDiff);

        }
    }
}
