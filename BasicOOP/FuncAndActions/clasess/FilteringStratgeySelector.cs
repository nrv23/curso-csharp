using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndActions.clasess
{
    public  class FilteringStratgeySelector
    {

        private static Dictionary<string, Func<int, bool>> strategies = new()
        {
            { "Even", n => n % 2 == 0 },
            { "Odd", n => n % 1 == 0 },
            { "Positive", n => n > 0 },
            { "Negative", n => n < 0 },
        };

        public  IEnumerable<string> FilteringStrategiesNames  => strategies.Keys;

        public static Func<int, bool> GetFilteringStrategy(string criteria)
        {
            var stratgey = strategies[criteria];
            return stratgey;
        }
    }
}
