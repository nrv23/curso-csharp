using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.clasess
{
    public class FullName
    {

        public string First { get; init; }
        public string Last { get; init; }

        public override bool Equals(object? obj)
        {
            return obj is FullName name &&
                   First == name.First &&
                   Last == name.Last;
        }


        public override string ToString() => $"{First} {Last}";


    }
}
