using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Date_Modifier
{
    public class DateModifier
    {
        private int dateDiff;

        public DateModifier (string firstDate, string secondDate)
        {
            this.dateDiff = Math.Abs((Convert.ToDateTime(firstDate) - Convert.ToDateTime(secondDate)).Days);
        }

        public int DateDiff
        {
            get {
                    return this.dateDiff;
                }
        }

    }
}
