using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHoddDotNet.clasess
{
    public class SpecificLineFromTextFileReader : IDisposable
    {
        public void Dispose()
        {
            _streamReader.Dispose(); // libera los recursos
        }

        private readonly StreamReader _streamReader;
        public SpecificLineFromTextFileReader(string path)
        {
            _streamReader = new StreamReader(path);
        }

        public string ReadLineNumber(int lineNumber)
        {
            _streamReader.DiscardBufferedData(); // limpia el buffer
            _streamReader.BaseStream.Seek(0, SeekOrigin.Begin); // vuelve al inicio del archivo
            string line = "";
            for (int i = 0; i < lineNumber ; i++)
            {
                line = _streamReader.ReadLine();
            }
            return line;
        }
    }
}
