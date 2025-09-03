using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP
{
    public class NumbersSumCalculator
    {

        public virtual int Calculate(List<int> numbers)
        {
            int sum = 0;

            foreach(var num in numbers)
            {
                if(ShallBeAdded(num))
                {
                    sum += num;
                }
            }

            return sum;
        }

        protected virtual bool ShallBeAdded(int number)
        {
            return true;
        }
    }

    public class PositiveNumbersSumCalculator: NumbersSumCalculator
    {

        protected override  bool ShallBeAdded(int number)
        {
            return number > 0;
        }
    }
}
