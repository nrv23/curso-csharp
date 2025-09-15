using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.exercises
{
    public class Pair<T>
    {
        public T First { get; private set; }
        public T Second { get; private set; }
        public Pair( T first, T second)
        {
            First = first;
            Second = second;    
        }

        public void ResetFirst() => First = default;
        public void ResetSecond() => Second = default;
    }
}
