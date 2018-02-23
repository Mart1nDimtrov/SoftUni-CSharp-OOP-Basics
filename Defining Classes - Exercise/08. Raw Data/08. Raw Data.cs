using _08.Raw_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carInput = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                Car newCar = new Car(carInput[0], int.Parse(carInput[1]), int.Parse(carInput[2]), int.Parse(carInput[3]), carInput[4]);
                newCar.AddTire(double.Parse(carInput[5]), int.Parse(carInput[6]));
                newCar.AddTire(double.Parse(carInput[7]), int.Parse(carInput[8]));
                newCar.AddTire(double.Parse(carInput[9]), int.Parse(carInput[10]));
                newCar.AddTire(double.Parse(carInput[11]), int.Parse(carInput[12]));
                cars.Add(newCar);
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                cars.Where(c => c.cargo.cargoType == cargoType && c.tires.Where(t => t.tirePressure < 1).FirstOrDefault() != null)
                                .ToList()
                                .ForEach(c => Console.WriteLine(c.model));
            }
            else
            {
                cars.Where(c => c.cargo.cargoType == cargoType && c.engine.enginePower > 250)
                .ToList()
                .ForEach(c => Console.WriteLine(c.model));
            }
            
        }
    }
}
