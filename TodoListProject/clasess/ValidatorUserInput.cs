using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListProject.clasess
{
    public class ValidatorUserInput
    {
        public bool IsValidMenuOption(char op)
        {

            // usando switch expressions
            return (char.ToLower(op)) switch // esto funciona como sl switch pero reducido 
            {
                'a' or 'r' or 'l' or 'g' or 'e' => true,
                _ => false // el valor _ representa el default case en el switch
            };
        }
        private bool IsValidUserInput(string x)
        {

            int numberConversionResult;
            int.TryParse(x, out numberConversionResult);

            return numberConversionResult > 0;
        }

        public int? processUserInput(string x)
        {
            if (string.IsNullOrEmpty(x) || x == "0") return null; 
            if (!this.IsValidUserInput(x)) return 0;
            return int.Parse(x);
            
        }
    }
}
