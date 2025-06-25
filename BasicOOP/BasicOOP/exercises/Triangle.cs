using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.exercises
{
    public class Triangle
    {

        private int _base;
        private int height;

        public Triangle(int _baseValue, int _height)
        {
            _base = _baseValue;
            height = _height;
        }

        public int CalculateArea()
        {
            return (_base * height) / 2;
        }

        public string AsString()
        {

            return $"Base is {_base}, height is {height}";
        }
    }
}
