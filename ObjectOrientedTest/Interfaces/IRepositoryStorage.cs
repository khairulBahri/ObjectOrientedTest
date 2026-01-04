using ObjectOrientedTest.Interfaces;

namespace ObjectOrientedTest.Interfaces
{
    public interface IRepositoryStorage
    {
        bool TryAdd(string key, IItemContent content);
        bool TryGet(string key, out IItemContent content);
        bool Remove(string key);
    }
}
