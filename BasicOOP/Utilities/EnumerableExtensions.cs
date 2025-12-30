using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class EnumerableExtensions
    {
        public static string AsString<T>(this IEnumerable<T> items)
        {
            return string.Join(Environment.NewLine, items);
        }
    }
}
