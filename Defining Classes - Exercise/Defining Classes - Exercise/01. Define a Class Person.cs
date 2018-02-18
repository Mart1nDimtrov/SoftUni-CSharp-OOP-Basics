﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Exercise.Models;

namespace Defining_Classes___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family fam = new Family();
            

            for (int i = 0; i < count; i++)
            {
                string[] member = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                fam.AddMember(member[0], int.Parse(member[1]));

            }
            Console.WriteLine(fam.GetOldestMember());

        }
    }
}
