using System.Collections.Concurrent;
using ObjectOrientedTest.Interfaces;

namespace ObjectOrientedTest.Storage
{
    public sealed class InMemoryRepositoryStorage : IRepositoryStorage
    {
        private readonly ConcurrentDictionary<string, IItemContent> _storage
            = new ConcurrentDictionary<string, IItemContent>();

        public bool TryAdd(string key, IItemContent content)
        {
            return _storage.TryAdd(key, content);
        }

        public bool TryGet(string key, out IItemContent content)
        {
            return _storage.TryGetValue(key, out content);
        }

        public bool Remove(string key)
        {
            return _storage.TryRemove(key, out _);
        }
    }
}
