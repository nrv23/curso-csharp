using CookiesCookbook.Enums;
using CookiesCookbook.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CookiesCookbook.Clasess
{
    public class FileMetaData
    {

        private string Name { get; set; }
        private FileFormat Format { get; }


        public FileMetaData(string name, FileFormat format)
        {
            Name = name;
            Format = format;
        }

        public string GetPath() => $"{Name}.{Format.AsFileExtension()}";
    }
}
