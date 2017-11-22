namespace GenerativeFactory.Library
{
    using System.Reflection;

    public interface IActivator
    {
        ConstructorInfo Source { get; }

        object Create(params object[] arguments);
    }
}
