using ObjectOrientedTest.Enums;
using ObjectOrientedTest.Interfaces;


namespace ObjectOrientedTest.Contents
{
    public sealed class JsonItemContent : IItemContent
    {
        public string Content { get; }
        public ItemType Type => ItemType.Json;

        public JsonItemContent(string content)
        {
            Content = content;
        }
    }
}
