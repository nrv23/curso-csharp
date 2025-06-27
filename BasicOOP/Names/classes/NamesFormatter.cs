using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names.classes
{
    public class NamesFormatter
    {

        public static string Format(List<string> strings) => string.Join(Environment.NewLine, strings);

    }
}
