using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP.Extensions
{
    public static  class ListIntExtension
    {

        public static List<int> TakeEverySecond(this List<int> numbers) {
            
            var newList = new List<int>();
            if (numbers is null) {
                throw new ArgumentNullException($"{nameof(numbers)} is null");
            }   
        
            if( numbers.Count == 0)
            {
                return new List<int>();
            }

            if(numbers.Count == 1)
            {
                return new List<int> { numbers[0] };
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    newList.Add(numbers[i]);
                }
            }

            return newList;
        }
    }
}
