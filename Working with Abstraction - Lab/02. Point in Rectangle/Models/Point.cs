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

        /*
       public static bool operator >=(Point p1, Point p2)
        {
            if (p1.X >= p2.X && p1.Y >= p2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            if (p1.X <= p2.X && p1.Y <= p2.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.X != p2.X || p1.Y != p2.Y)
            {
                return true;
            }
            return false;
        }
        */
    }
}
