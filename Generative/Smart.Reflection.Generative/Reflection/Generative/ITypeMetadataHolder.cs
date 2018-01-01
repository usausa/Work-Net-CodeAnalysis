namespace Smart.Reflection.Generative
{
    using System.Reflection;

    public interface ITypeMetadataHolder
    {
        IActivator FindActivator(ConstructorInfo ci);

        IAccessor FindAccessor(PropertyInfo pi);
    }
}
