using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel_Reservation
{
    class Program
    {
        public enum Season { Autumn = 1, Spring = 2, Winter = 3, Summer = 4 };
        static void Main(string[] args)

        {
        string[] hotelRes = Console.ReadLine()
                                    .Split()
                                    .ToArray();

            if (hotelRes.Length == 3)
            {
                Console.WriteLine("{0:F2}", PriceCalculator.CalcultaPrice(decimal.Parse(hotelRes[0]),
                    int.Parse(hotelRes[1]), (int)(Season)Enum.Parse(typeof(Season), hotelRes[2]))); 
            }
            else if (hotelRes.Length == 4)
            {

                Console.WriteLine("{0:F2}", PriceCalculator.CalcultaPrice(decimal.Parse(hotelRes[0]),
                    int.Parse(hotelRes[1]), (int)(Season)Enum.Parse(typeof(Season), hotelRes[2]), hotelRes[3]));


            }

        }
    }
}
