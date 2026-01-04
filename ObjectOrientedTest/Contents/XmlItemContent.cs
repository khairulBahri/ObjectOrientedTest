using ObjectOrientedTest.Enums;
using ObjectOrientedTest.Interfaces;

namespace ObjectOrientedTest.Contents
{
    public sealed class XmlItemContent : IItemContent
    {
        public string Content { get; }
        public ItemType Type => ItemType.Xml;

        public XmlItemContent(string content)
        {
            Content = content;
        }
    }
}
