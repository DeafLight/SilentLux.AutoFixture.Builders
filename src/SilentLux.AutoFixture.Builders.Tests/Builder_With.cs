using FluentAssertions;
using SilentLux.AutoFixture.Builders.Tests.Artifacts;
using SilentLux.AutoFixture.Moq.Xunit2;
using Xunit;

namespace SilentLux.AutoFixture.Builders.Tests
{
    public class Builder_With
    {
        [Theory]
        [AutoMoqData]
        public void With_should_call_the_action(DummyBuilder sut)
        {
            var hasBeenCalled = false;

            sut.WithAction(() => hasBeenCalled = true);

            hasBeenCalled.Should().BeTrue();
        }
    }
}