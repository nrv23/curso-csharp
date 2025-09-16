using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.clasess
{
    public static class Calculator
    {
        public static T Square<T>(T number) where T:INumber<T>  => number * number;
        
    }
}
