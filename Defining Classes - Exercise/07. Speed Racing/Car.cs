using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    public class Car
    {
        public string model { get; set; }
        public double fuelAmount { get; set; }
        public double fuelConsumption { get; set; }
        public double distanceTraveled { get; set; }

        public Car (string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTraveled = 0;
        }

        public void CalculateDistanceTraveled (double distance)
        {
            if (distance * this.fuelConsumption <= this.fuelAmount)
            {
                this.fuelAmount -= (distance * this.fuelConsumption);
                this.distanceTraveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
