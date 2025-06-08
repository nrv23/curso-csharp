using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.classes
{
    public class Calculate
    {

        public Calculate() { 
        
        }

        public int ProcessOperation(int x, int y, char op)
        {
            int result;
            switch (char.ToLower(op))
            {
                case 's':
                    result = Sum(x, y);
                    break;
                case 'r':
                    result = Subtract(x, y);
                    break;
                case 'm':
                    result = Multiply(x, y);
                    break;
                case 'd':
                    result = Divide(x, y);
                    break;

                default:
                    throw new NotImplementedException("Operación no implementada");
            }

            return result;
        }

        private int Sum(int x, int y) => x + y;
        

        private int Subtract(int x, int y) => x - y;
        

        private int Multiply(int x, int y)
        {
            return x * y;
        }

        private int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
