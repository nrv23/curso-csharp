using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndActions.clasess
{
    public class Filter
    {
        public List<T> FilterElements<T>(IEnumerable<T> elements, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var number in elements)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
