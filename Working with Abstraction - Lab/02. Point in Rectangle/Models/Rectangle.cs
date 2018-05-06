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
            this.TopRight = new Point(TopLeft.X, BottomLeft.Y);
            this.BottomLeft = new Point(BottomRight.X, TopLeft.Y);

        }

        public bool Contains(Point p)
        {
            if (p.X >= )
            {

            }
            return true;
        }
    }
}
