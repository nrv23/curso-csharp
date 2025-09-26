using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHoddDotNet.clasess
{
    public class AllLinesFromTextFileReader: IDisposable
    {
        private readonly StreamReader _streamReader;

        public AllLinesFromTextFileReader(string filePath)
        {
            _streamReader = new StreamReader(filePath); //your code goes here
        }

        public void Dispose()
        {
           _streamReader.Dispose(); // libera los recursos
        }

        public List<string> ReadAllLines()
        {
            _streamReader.DiscardBufferedData(); // limpia el buffer
            _streamReader.BaseStream.Seek(0, SeekOrigin.Begin); // vuelve al inicio del archivo

            var result = new List<string>();
            while (!_streamReader.EndOfStream)
            {
                result.Add(_streamReader.ReadLine());
            }
           
            return result;
        }
    
        //your code goes here
    }
}
