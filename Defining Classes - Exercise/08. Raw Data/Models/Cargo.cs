using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data.Models
{
    public class Cargo
    {
        public int cargoWeight { get; set; }
        public string cargoType { get; set; }

        public Cargo (int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }

    }
}
