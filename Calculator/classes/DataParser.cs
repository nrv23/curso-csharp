using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.classes
{
    public class DataParser
    {

        public DataParser() { 
        
        }
        
        public string ParseResponse(int x, int y, int result, char op)
        {
            string response = "";
            switch (char.ToLower(op))
            {
                case 's':
                    response = $"El resultado de {x} + {y} : {result}";
                    break;
                case 'r':
                    response = $"El resultado de {x} - {y} : {result}";
                    break;
                case 'm':
                    response = $"El resultado de {x} * {y} : {result}";
                    break;
                case 'd':
                    response = $"El resultado de {x} / {y} : {result}";
                    break;
            }

            return response;
        }
    }
}
