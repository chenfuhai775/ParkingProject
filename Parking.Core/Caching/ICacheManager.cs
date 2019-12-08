namespace Parking.Core.Caching
{
    using System;

    public interface ICacheManager : IDisposable
    {
        void Clear();
        T Get<T>(string key);
        bool IsSet(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        void Set(string key, object data, int cacheTime);
    }
}

