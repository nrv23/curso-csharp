using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaYSobreescribirPractica.clasess
{
    public class StringsProcessorManager
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }
    public class StringsProcessor
    {

        public virtual List<string> Process(List<string> strings) => strings;
    }

    public class StringsTrimmingProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> strings)
        {
            var result = new List<string>();

            foreach (var word in strings)
            {
                int half = word.Length / 2;
                result.Add(word.Substring(0, half));
            }

            return result;

        }
    }

    public class StringsUppercaseProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> strings)
        {
            if (strings == null || strings.Count == 0) return new List<string>();
            var stringsUpper = strings.Select(s => s.ToUpper()).ToList();
            return stringsUpper;
        }
    }
}
