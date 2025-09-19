using CustomCache.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache.clasess
{
    public class PrintingDataDonwloader : IDataDownloader
    {
        private readonly Cache<string, string> _cache = new();
        private readonly IDataDownloader _dataDownloader;

        public PrintingDataDonwloader(IDataDownloader dataDownloader)
        {
            _dataDownloader = dataDownloader;
        }
        public string DownloadData(string resourceId)
        {
            Console.WriteLine($"Downloading data for {resourceId}");
            var data = _cache.Get(resourceId, _dataDownloader.DownloadData);
            Console.WriteLine($"Data: {data}");
            return data;
        }
    }
}
