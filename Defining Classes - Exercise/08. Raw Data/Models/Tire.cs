using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data.Models
{
    public class Tire
    {
        public double tirePressure { get; set; }
        public int tireAge { get; set; }

        public Tire (double tirePressure, int tireAge)
        {
            this.tirePressure = tirePressure;
            this.tireAge = tireAge;
        }

    }
}
