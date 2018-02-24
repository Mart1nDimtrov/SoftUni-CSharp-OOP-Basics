using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Abstraction___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintRow(n);
        }

        public static void PrintRow(int n)
        {
            int space = n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new String(' ', space));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                space--;
            }

            space+=2;
            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new String(' ', space));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                space++;
            }

        }
    }
}
