using FluentAssertions;
using SilentLux.AutoFixture.Builders.Tests.Artifacts;
using SilentLux.AutoFixture.Moq.Xunit2;
using Xunit;

namespace SilentLux.AutoFixture.Builders.Tests
{
    public class Builder_Build
    {
        [Theory]
        [AutoMoqData]
        public void Build_should_return_an_object(DummyBuiler sut)
        {
            var res = sut.Build();

            res.GetType().Should().Be<object>();
            sut.HasNewInstanceBeenCalled.Should().BeTrue();
        }
    }
}