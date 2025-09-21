using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookiesCookbook.Clasess
{
    public class JSONStringsRepository: IStringsRepository
    {

        private static readonly string Separator = Environment.NewLine;
        public List<string> Read(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                return new List<string>();
            }
            var fileContent = System.IO.File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(fileContent);
        }

        public void Write(string filePath, List<string> allLines)
        {
            var fileContent = JsonSerializer.Serialize(allLines);
            System.IO.File.WriteAllText(filePath, fileContent);
        }
    }
}
