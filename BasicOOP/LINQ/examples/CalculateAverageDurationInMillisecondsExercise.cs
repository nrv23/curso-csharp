using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public class CalculateAverageDurationInMillisecondsExercise
    {
        public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
        {
            return timeSpans.Average(ts => ts.TotalMilliseconds);
        }
    }
}
