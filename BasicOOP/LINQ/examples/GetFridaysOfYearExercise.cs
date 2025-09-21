using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public enum DayOfWeek // retorna el indice comenzando en 0
    {
        Sunday,
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday,
        Friday, 
        Saturday
    }
    public class GetFridaysOfYearExercise
    {

        public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates)
        {
            return dates.Where(d => d.Year == year
            && (int)d.DayOfWeek == (int)DayOfWeek.Friday
            )
           // .Distinct<DateTime>(); // distinct genera valores unicos por la validacion del where
           .DistinctBy(d => d.Date);
        }
    }
}
