using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.classes
{
    public class ValidatorUserInput
    {

        private bool IsValidUserInput(string x)
        {

            int numberConversionResult;
            int.TryParse(x, out numberConversionResult);

            return numberConversionResult > 0;
        }

        public bool IsValidMenuOption(char op) {


            // usando switch expressions

            return (char.ToLower(op)) switch // esto funciona como sl switch pero reducido 
            {
                's' or 'r' or 'm' or 'd' => true,
                _ => false // el valor _ representa el default case en el switch
            };
        }

        public int processUserInput(string x)
        {
            if (!this.IsValidUserInput(x)) return 0;
            return int.Parse(x);
        }
    }
}
