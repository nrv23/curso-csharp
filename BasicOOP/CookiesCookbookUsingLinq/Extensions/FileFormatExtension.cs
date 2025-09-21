using CookiesCookbook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Extensions
{
    public static class FileFormatExtension
    {

        public static string AsFileExtension(this FileFormat fileFormat)
        {
            return fileFormat switch
            {
                FileFormat.txt => "txt",
                FileFormat.json => "json",
                _ => throw new NotSupportedException($"The file format {fileFormat} is not supported."),
            };
        }

    }
}
