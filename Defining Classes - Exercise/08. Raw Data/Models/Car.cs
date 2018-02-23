using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data.Models
{
    public class Car
    {
        public string model;
        public List<Tire> tires;
        public Engine engine;
        public Cargo cargo;

        public Car (string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            this.tires = new List<Tire>();
        }

        public void AddTire(double tirePressure, int tireAge)
        {
            Tire tire = new Tire(tirePressure, tireAge);
            this.tires.Add(tire);
        }

    }
}
