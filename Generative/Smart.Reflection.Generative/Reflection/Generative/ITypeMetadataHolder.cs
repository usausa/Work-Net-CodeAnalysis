namespace Smart.Reflection.Generative
{
    using System.Reflection;

    public interface ITypeMetadataHolder
    {
        IActivator CreateActivator(ConstructorInfo ci);

        IAccessor CreateAccseor(PropertyInfo pi);
    }
}
