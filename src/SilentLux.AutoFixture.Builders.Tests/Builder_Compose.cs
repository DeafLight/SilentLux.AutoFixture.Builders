using AutoFixture.Dsl;
using FluentAssertions;
using SilentLux.AutoFixture.Builders.Tests.Artifacts;
using SilentLux.AutoFixture.Moq.Xunit2;
using Xunit;

namespace SilentLux.AutoFixture.Builders.Tests
{
    public class Builder_Compose
    {
        [Theory]
        [AutoMoqData]
        public void Compose_should_return_a_PostProcessComposer(
            DummyBuilder sut
        )
        {
            var res = sut.Compose();

            res.Should().BeAssignableTo<IPostprocessComposer<object>>();
        }
    }
}