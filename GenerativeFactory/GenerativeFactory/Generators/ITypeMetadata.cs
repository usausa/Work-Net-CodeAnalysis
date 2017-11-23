namespace GenerativeFactory.Generators
{
    using System.Reflection;

    using GenerativeFactory.Library;

    public interface ITypeMetadata
    {
        IActivator FindActivator(ConstructorInfo ci);

        IAccessor FindAccessor(PropertyInfo pi);
    }
}
