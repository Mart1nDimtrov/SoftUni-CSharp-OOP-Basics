using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Point_in_Rectangle.Models
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point TopRight { get; set; }
        public Point BottomRight { get; set; }
        public Point BottomLeft { get; set; }

        public Rectangle(Point top, Point bottom)
        {
            this.TopLeft = top;
            this.BottomRight = bottom;
            this.TopRight = new Point(bottom.X, top.Y);
            this.BottomLeft = new Point(top.X, bottom.Y);
        }

        public void Contains(Point p)
        {
            if ((p.X >= TopLeft.X && p.Y >= TopLeft.Y) && (BottomRight.X >= p.X) && (BottomRight.Y >= p.Y)
                && (BottomLeft.X <= p.X) && (BottomLeft.Y >= p.Y) && (TopRight.X >= p.X) && (TopRight.Y <= p.Y))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
