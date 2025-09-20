using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public class Contains
    {

        public bool ItContains<T>(IEnumerable<T> elements, T key)
        {
            return elements.Contains(key);
        }
    }
}
