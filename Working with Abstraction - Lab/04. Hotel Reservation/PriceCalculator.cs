using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel_Reservation
{ 
    public class PriceCalculator
    {

        public static decimal CalcultaPrice(decimal pPD, int numDays, int season)
        {
            return (pPD * season) * numDays;
        }

        public static decimal CalcultaPrice(decimal pPD, int numDays, int season, string discountType)
        {
            if (discountType == "VIP")
            {
                return ((pPD * season) * numDays) - (((pPD * season) * numDays) * 0.20m);
            }
            if (discountType == "SecondVisit")
            {
                return ((pPD * season) * numDays) - (((pPD * season) * numDays) * 0.10m);
            }
            return (pPD * season) * numDays;

        }

    }
}
