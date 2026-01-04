using ObjectOrientedTest.Enums;

namespace ObjectOrientedTest.Interfaces
{
    public interface IItemContent
    {
        string Content { get; }
        ItemType Type { get; }
    }
}
