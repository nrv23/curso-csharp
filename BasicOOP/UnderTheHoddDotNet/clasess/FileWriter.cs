using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHoddDotNet.clasess
{
    public class FileWriter: IDisposable
    {
        private readonly StreamWriter _stringWriter;
        public FileWriter(string path)
        {
            _stringWriter = new StreamWriter(path,true);// el segundo parametro es para agregar exto al final del archivo
        }

        public void Dispose()
        {
            _stringWriter.Dispose(); // libera los recursos
        }

        public void Write(string content)
        {
            // write content to file
            _stringWriter.WriteLine(content);
            _stringWriter.Flush(); // libera el buffer 
        }
    }
}
