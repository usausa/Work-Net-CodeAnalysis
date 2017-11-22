namespace GenerativeFactory
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using GenerativeFactory.Generators;
    using GenerativeFactory.Library;

    public class SampleDataMetadataRepository : IMetadataRepository
    {
        private readonly Dictionary<ConstructorInfo, IActivator> activators = new Dictionary<ConstructorInfo, IActivator>();

        private readonly Dictionary<PropertyInfo, IAccessor> accessors = new Dictionary<PropertyInfo, IAccessor>();


        public SampleDataMetadataRepository()
        {
            var ctor0 = typeof(Data).GetConstructor(Type.EmptyTypes);
            activators[ctor0] = new Activator0(ctor0);

            var ctor1 = typeof(Data).GetConstructor(new[] { typeof(int), typeof(string) });
            activators[ctor1] = new Activator1(ctor1);

            var piIntValue = typeof(Data).GetProperty(nameof(Data.IntValue));
            accessors[piIntValue] = new IntValueAccessor(piIntValue);

            var piStringValue = typeof(Data).GetProperty(nameof(Data.StringValue));
            accessors[piStringValue] = new StringValueAccessor(piStringValue);
        }

        public IActivator ResolveActivator(ConstructorInfo ci)
        {
            return activators[ci];
        }

        public IAccessor ResolveAccessor(PropertyInfo pi)
        {
            return accessors[pi];
        }

        // Generative Activators

        private sealed class Activator0 : IActivator
        {
            public ConstructorInfo Source { get; }

            public Activator0(ConstructorInfo source)
            {
                Source = source;
            }

            public object Create(params object[] arguments)
            {
                return new Data();
            }
        }

        private sealed class Activator1 : IActivator
        {
            public ConstructorInfo Source { get; }

            public Activator1(ConstructorInfo source)
            {
                Source = source;
            }

            public object Create(params object[] arguments)
            {
                return new Data((int)arguments[0], (string)arguments[1]);
            }
        }

        // Generative Accessors

        private sealed class IntValueAccessor : IAccessor
        {
            public PropertyInfo Source { get; }

            public IntValueAccessor(PropertyInfo source)
            {
                Source = source;
            }

            public object GetValue(object target)
            {
                return ((Data)target).IntValue;
            }

            public void SetValue(object target, object value)
            {
                if (value == null)
                {
                    ((Data)target).IntValue = default;
                }
                else
                {
                    ((Data)target).IntValue = (int)value;
                }
            }
        }

        private sealed class StringValueAccessor : IAccessor
        {
            public PropertyInfo Source { get; }

            public StringValueAccessor(PropertyInfo source)
            {
                Source = source;
            }

            public object GetValue(object target)
            {
                return ((Data)target).StringValue;
            }

            public void SetValue(object target, object value)
            {
                ((Data)target).StringValue = (string)value;
            }
        }
    }
}
