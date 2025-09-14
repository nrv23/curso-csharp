using GameDataParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.clasess
{
    public class FileReader : IFileReader
    {

        public string Read(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
