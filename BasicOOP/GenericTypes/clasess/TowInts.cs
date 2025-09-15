using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.clasess
{
    public class TowInts
    {
        public int Max { get;  }
        public int Min { get; }
        public TowInts(int max, int min)
        {
            Max = max;
            Min = min;
        }
    }
}
