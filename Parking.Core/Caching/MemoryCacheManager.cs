namespace Parking.Core.Caching
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Caching;
    using System.Text.RegularExpressions;

    public class MemoryCacheManager : ICacheManager, IDisposable
    {
        public virtual void Clear()
        {
            foreach (KeyValuePair<string, object> pair in (IEnumerable<KeyValuePair<string, object>>) this.Cache)
            {
                this.Remove(pair.Key);
            }
        }

        public virtual void Dispose()
        {
        }

        public virtual T Get<T>(string key)
        {
            return (T) this.Cache[key];
        }

        public virtual bool IsSet(string key)
        {
            return this.Cache.Contains(key, null);
        }

        public virtual void Remove(string key)
        {
            this.Cache.Remove(key, null);
        }

        public virtual void RemoveByPattern(string pattern)
        {
            Regex regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, object> pair in (IEnumerable<KeyValuePair<string, object>>) this.Cache)
            {
                if (regex.IsMatch(pair.Key))
                {
                    list.Add(pair.Key);
                }
            }
            foreach (string str in list)
            {
                this.Remove(str);
            }
        }

        public virtual void Set(string key, object data, int cacheTime)
        {
            if (data != null)
            {
                CacheItemPolicy policy = new CacheItemPolicy {
                    AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes((double) cacheTime)
                };
                this.Cache.Add(new CacheItem(key, data), policy);
            }
        }

        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }
    }
}

