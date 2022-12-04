using Core.Utilities.Ioc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        IMemoryCache _cache;
        public MemoryCacheManager()
        {
            _cache = ServiceTool.ServiceProvider.GetService<IMemoryCache>();
        }

        public void Add(string key, object data, int duration)
        {
            _cache.Set(key, data, TimeSpan.FromMinutes(duration));
        }

        public T Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }

        public object Get(string key)
        {
            return _cache.Get(key);
        }

        public bool IsAdd(string key)
        {
            return _cache.TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {

            var coherentState = typeof(MemoryCache).GetRuntimeFields().Where(p => p.Name == "_coherentState").FirstOrDefault();
            var collectionCoherentStateType = coherentState.GetValue(_cache).GetType();
            var collectionCoherentStateValue = coherentState.GetValue(_cache);
            var cacheEntriesCollectionDefinition = collectionCoherentStateType.GetProperty("EntriesCollection",
                BindingFlags.NonPublic | BindingFlags.Instance);
            var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(collectionCoherentStateValue) as dynamic;

            List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheItem in cacheEntriesCollection)
            {

                ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);


                cacheCollectionValues.Add(cacheItemValue);
            }

            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString())).Select(d => d.Key).ToList();

            foreach (var key in keysToRemove)
            {
                _cache.Remove(key);
            }
        }
    }
}