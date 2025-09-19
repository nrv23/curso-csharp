using CustomCache.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCache.interfaces;
using System.Diagnostics;

namespace CustomCache.clasess
{
    public class Cache<TKey,TValue>
    {
        private readonly Dictionary<TKey, TValue> _cache;

        public Cache()
        {
            _cache = new Dictionary<TKey, TValue>();
        }

        public void Set(TKey key, TValue value) { 
            _cache[key] = value;
        }

        public TValue Get(TKey key, Func<TKey, TValue> getForTheFirstTime)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (!_cache.ContainsKey(key))
            {
                _cache[key] = getForTheFirstTime(key);
            }
            stopwatch.Stop();
            Console.WriteLine($"Cache retrieval time: {stopwatch.ElapsedMilliseconds} ms");
            return _cache[key];
        }
    }
}
