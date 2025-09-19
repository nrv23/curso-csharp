using CustomCache.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache.clasess
{
    public class SlowDataDownloader : IDataDownloader
    {
        public string DownloadData(string resourceId)
        {
            //let's imagine this method downloads real data,
            //and it does it slowly
            Thread.Sleep(1000);
            return $"Some data for {resourceId}";
        }
    }
}
