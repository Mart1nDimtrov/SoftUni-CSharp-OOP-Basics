using _02.Point_in_Rectangle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            Point p1 = new Point(points[0], points[1]);
            Point p2 = new Point(points[2], points[3]);
            
            Rectangle rect = new Rectangle(p1, p2);
            int pointCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointCount; i++)
            {
                int[] pointsInput = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();
                rect.Contains(new Point(pointsInput[0], pointsInput[1]));
            }
        }
    }
}
