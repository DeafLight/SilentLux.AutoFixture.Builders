using AutoFixture;

namespace SilentLux.AutoFixture.Builders.Tests.Artifacts
{
    public class DummyBuiler : Builder<DummyBuiler, object>
    {
        public bool HasNewInstanceBeenCalled { get; private set; }

        public DummyBuiler(IFixture fixture) :
            base(fixture)
        {
        }

        protected override object NewInstance()
        {
            HasNewInstanceBeenCalled = true;
            return new object();
        }
    }
}