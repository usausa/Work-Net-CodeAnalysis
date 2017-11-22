namespace GenerativeFactory.Generators
{
    using System.Reflection;

    using GenerativeFactory.Library;

    public interface IMetadataRepository
    {
        IActivator ResolveActivator(ConstructorInfo ci);

        IAccessor ResolveAccessor(PropertyInfo pi);
    }
}
