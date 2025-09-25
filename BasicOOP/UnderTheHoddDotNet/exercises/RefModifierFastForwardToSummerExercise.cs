using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHoddDotNet.exercises
{
    public class RefModifierFastForwardToSummerExercise
    {
        public static void FastForwardToSummer(ref DateTime date)
        {
           DateTime summerFirstDate = new DateTime(2024, 6, 21);

            if(date.Month < 6)
            {
                date = summerFirstDate;
            }
            else if(date.Month == 6 && date.Day < 21)
            {
                date = summerFirstDate;
            }
        }
    }
}
