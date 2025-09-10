using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.exercises
{
    public static class ExceptionsDivisionExercise
    {
        public static int DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
                
            }
            catch
            {

                return b;
            }
            finally
            {
                if (b == 0)
                {
                    Console.WriteLine( "Division by zero.");
                }

               Console.WriteLine( "The DivideNumbers method ends.");


            }

            
        }
    }
}
