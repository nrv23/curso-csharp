using CustomCache.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache.clasess
{
    public class CachingDataDownloader: IDataDownloader
    {
        private readonly Cache<string, string> _cache = new();
        private readonly IDataDownloader _dataDownloader;

        public CachingDataDownloader(IDataDownloader dataDownloader)
        {
            _dataDownloader = dataDownloader;
        }
        public string DownloadData(string resourceId)
        {
            return _cache.Get(resourceId, _dataDownloader.DownloadData);
        }
    }
}
