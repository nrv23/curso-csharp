using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache.interfaces
{
    public interface IDataDownloader
    {
        string DownloadData(string url);
    }
}
