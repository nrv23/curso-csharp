using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Names.classes
{

    public class ListNames
    {
        public  List<string> Names { get; } = new List<string>();

        public void AddName(string name)
        {
            if (NamesValidator.IsValid(name))
            {
                Names.Add(name);
            }
        }

        public void AddNames(List<string> stringsFromFile)
        {
            foreach (var name in stringsFromFile)
            {
                AddName(name);
            }
        }
    }
}
