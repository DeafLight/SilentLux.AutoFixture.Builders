namespace SilentLux.AutoFixture.Builders
{
    public interface IBuilder<out T>
    {
        /// <summary>
        ///     Creates an instance of T
        /// </summary>
        /// <returns></returns>
        T Build();
    }
}