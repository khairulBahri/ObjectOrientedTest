using ObjectOrientedTest.Interfaces;

namespace ObjectOrientedTest.Validators
{
    public sealed class DummyContentValidator : IContentValidator
    {
        public void Validate(IItemContent content)
        {
            // Validation logic intentionally not implemented.
            // Required by specification.
        }
    }
}
