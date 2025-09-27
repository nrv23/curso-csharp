using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheHoddDotNet.clasess
{
    public class CsvData {

        public string[] Columns { get;}
        public IEnumerable<string[]> Rows { get;}

        public CsvData(IEnumerable<string[]> rows, string[] columns)
        {
            Rows = rows;
            Columns = columns;
        }
    }
    public class CsvReader
    {
        private readonly StreamReader _reader;
        const string Separator = ",";
        


        public CsvData  Read(string path)
        {
            using var reader = new StreamReader(path);
            var columns = reader.ReadLine().Split(Separator);

            var rows = new List<string[]>();

            while (!reader.EndOfStream) {
                rows.Add(reader.ReadLine().Split(Separator));
            }

            return new CsvData(rows, columns);
        }
    }
}
