using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.extensions
{
    public static class StackExtensions
    {
        public static bool DoesContainAny(this Stack<string>  value, params string[] givenWords)
               => value.Any(value => givenWords.Contains(value));
    }
}
