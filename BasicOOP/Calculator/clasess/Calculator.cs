﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.clasess
{
    public class Calculate
    {

        public static int Sum(int x, int y) => x + y;


        public static int Subtract(int x, int y) => x - y;


        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
