﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Point_in_Rectangle.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

       public static bool operator >=(Point p, Point other)
        {
            return true;
        }

        public static bool operator <=(Point p, Point other)
        {
            return true;
        }
        public static bool operator ==(Point p, Point other)
        {
            return true;
        }
        public static bool operator !=(Point p, Point other)
        {
            return true;
        }

    }
}
