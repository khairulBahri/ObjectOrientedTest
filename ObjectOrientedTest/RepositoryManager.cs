using System;
using System.Collections.Generic;
using ObjectOrientedTest.Contents;
using ObjectOrientedTest.Enums;
using ObjectOrientedTest.Interfaces;

namespace ObjectOrientedTest
{
    public sealed class RepositoryManager
    {
        private readonly IRepositoryStorage _storage;
        private readonly IContentValidator _validator;
        private bool _initialized;

        public RepositoryManager(
            IRepositoryStorage storage,
            IContentValidator validator)
        {
            _storage = storage ?? throw new ArgumentNullException(nameof(storage));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public void Initialize()
        {
            if (_initialized)
                throw new InvalidOperationException("Repository already initialized.");

            _initialized = true;
        }

        public void Register(string itemName, string itemContent, int itemType)
        {
            EnsureInitialized();

            if (string.IsNullOrWhiteSpace(itemName))
                throw new ArgumentException("Item name is required.");

            IItemContent content = CreateItemContent(itemContent, itemType);

            _validator.Validate(content);

            if (!_storage.TryAdd(itemName, content))
                throw new InvalidOperationException("Item already exists.");
        }

        public string Retrieve(string itemName)
        {
            EnsureInitialized();

            if (!_storage.TryGet(itemName, out var content))
                throw new KeyNotFoundException("Item not found.");

            return content.Content;
        }

        public int GetType(string itemName)
        {
            EnsureInitialized();

            if (!_storage.TryGet(itemName, out var content))
                throw new KeyNotFoundException("Item not found.");

            return (int)content.Type;
        }

        public void Deregister(string itemName)
        {
            EnsureInitialized();
            _storage.Remove(itemName);
        }

        private void EnsureInitialized()
        {
            if (!_initialized)
                throw new InvalidOperationException("Repository not initialized.");
        }

        private static IItemContent CreateItemContent(string content, int type)
        {
            ItemType itemType = (ItemType)type;

            switch (itemType)
            {
                case ItemType.Json:
                    return new JsonItemContent(content);

                case ItemType.Xml:
                    return new XmlItemContent(content);

                default:
                    throw new ArgumentException("Unsupported item type.");
            }
        }
    }
}
