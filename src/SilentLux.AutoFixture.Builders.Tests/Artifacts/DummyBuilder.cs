using AutoFixture;
using System;

namespace SilentLux.AutoFixture.Builders.Tests.Artifacts
{
    public class DummyBuilder : Builder<DummyBuilder, object>
    {
        public bool HasNewInstanceBeenCalled { get; private set; }

        public DummyBuilder(IFixture fixture) :
            base(fixture)
        {
        }

        public DummyBuilder WithAction(Action action) =>
            With(action);

        protected override object NewInstance()
        {
            HasNewInstanceBeenCalled = true;
            return new object();
        }
    }
}