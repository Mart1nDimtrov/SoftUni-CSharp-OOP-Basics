using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data.Models
{
    public class Engine
    {
        public int engineSpeed { get; set; }
        public int enginePower { get; set; }

        public Engine (int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
    }
}
