using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP.Exercises
{
    public static class NumericTypesDescriber
    {
        public static string Describe(object someObject)
        {
            //your code goes here

            
            //return someObject switch
            //{
            //    int i => $"This is an integer with value {i}",
            //    double d => $"This is a double with value {d}",
            //    float f => $"This is a float with value {f}",
            //    long l => $"This is a long with value {l}",
            //    decimal m => $"This is a decimal with value {m}",
            //    _ => "Unknown type"
            //};

            if(someObject is int i)
            {
                return $"Int of value {i}";
            }
             if(someObject is double d)
            {
                return $"Double of value {d}";
            }
             if(someObject is decimal m)
            {
                return $"Decimal of value {m}";
            }

            return null;
        }
    }
}
