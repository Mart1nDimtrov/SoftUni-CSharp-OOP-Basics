using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carInput = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                Car newCar = new Car(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]));
                cars.Add(newCar);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandSplit = command
                                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();
                Car car = cars.Where(c => c.model == commandSplit[1])
                              .First();
                car.CalculateDistanceTraveled(double.Parse(commandSplit[2]));
              
                command = Console.ReadLine();
            }

            cars.ToList()
                .ForEach(c => Console.WriteLine($"{c.model} {c.fuelAmount:F2} {c.distanceTraveled}"));

        }
    }
}
