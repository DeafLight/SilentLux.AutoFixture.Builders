using AutoFixture;
using AutoFixture.Dsl;

namespace SilentLux.AutoFixture.Builders
{
    /// <summary>
    ///     Extending this class allows to create builders for objects and then
    ///     fall back to AutoFixture composition
    /// </summary>
    /// <typeparam name="TBuilder"></typeparam>
    /// <typeparam name="TAnyType"></typeparam>
    public abstract class Builder<TBuilder, TAnyType> :
        IBuilder<TAnyType>
        where TBuilder : Builder<TBuilder, TAnyType>
    {
        protected Builder(IFixture fixture)
        {
            Fixture = fixture;
        }

        protected IFixture Fixture { get; }

        public TAnyType Build()
        {
            return NewInstance();
        }

        public IPostprocessComposer<TAnyType> Compose()
        {
            return Fixture.Build<TAnyType>().FromFactory(NewInstance);
        }

        protected abstract TAnyType NewInstance();
    }
}