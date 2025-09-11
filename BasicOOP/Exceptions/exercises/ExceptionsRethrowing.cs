using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.exercises
{
    public class ExceptionsRethrowing
    {

        public static int GetMaxValue(List<int> numbers)
        {
            try
            {
                return numbers.Max();
            }
            catch (ArgumentNullException anex)
            {
                throw new ArgumentNullException("The numbers list cannot be is null.", anex);
            }
            catch (InvalidOperationException ioex)
            {
                Console.WriteLine("The numbers list cannot be empty.");
                throw ioex;
            }
        }
    }
}
