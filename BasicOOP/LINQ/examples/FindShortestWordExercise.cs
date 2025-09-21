using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public  class FindShortestWordExercise
    {

        public static string FindShortestWord(IEnumerable<string> words)
        {
            return words.OrderBy(x => x.Length).First();
        }
    }
}
