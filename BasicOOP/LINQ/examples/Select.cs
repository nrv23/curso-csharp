using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public class Select
    {

        public IEnumerable<int> DoubledNumber(List<int> numbers)
        {
            return numbers.Select(n => n * 2);
        }

        public IEnumerable<string> UpperCaseWords(List<string> words) => words.Select(n => n.ToUpper());  
        
        public IEnumerable<string> NumbersAsStrings(List<int> numbers) => numbers.Select(n => n.ToString());

        public IEnumerable<string> IndexedWords(IEnumerable<string> words) => words.Select((w, index) => $"{index + 1}: {w}");
    }
}
