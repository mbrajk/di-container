using System;
using DependencyInjection.Enums;

namespace DependencyInjection
{
    public class ServiceDescriptor
    {
        public ServiceDescriptor(ServiceLifetime lifetime, object implementation)
        {
            ServiceLifetime = lifetime;
            Implementation = implementation;
            Type = implementation.GetType();
        }
        
        // public ServiceDescriptor(ServiceLifetime lifetime, Type type, object implementation = default)
        // {
        //     ServiceLifetime = lifetime;
        //     Implementation = implementation;
        //     Type = type;
        // }

        public ServiceLifetime ServiceLifetime { get; }
        public object Implementation { get; set; }
        public Type Type { get; }
    }
}