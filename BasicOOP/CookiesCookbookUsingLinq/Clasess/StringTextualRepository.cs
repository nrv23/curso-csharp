using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Clasess
{
    public interface IStringsRepository
    {
        List<string> Read(string filePath);
        void Write(string filePath, List<string> allLines);
    }

    public class StringTextualRepository : IStringsRepository
    {
        private static readonly string Separator = Environment.NewLine;
        public List<string> Read(string filePath)
        {
            if(!System.IO.File.Exists(filePath))
            {
                return new List<string>();
            }   
            var fileContent = System.IO.File.ReadAllText(filePath);
            return fileContent.Split(Separator).ToList(); 
        }

        public void Write(string filePath, List<string> allLines)
        {
            var fileContent = string.Join(Separator, allLines);
            System.IO.File.WriteAllText(filePath, fileContent);
        }
    }
}
