using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInjection.Enums;

namespace DependencyInjection
{
    public class ServiceContainer
    {
        private readonly List<ServiceDescriptor> _serviceDescriptors;

        public ServiceContainer(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        public T GetService<T>()
        {
            var descriptor = _serviceDescriptors.SingleOrDefault(s => s.Type == typeof(T));
            if (descriptor == null)
            {
                throw new Exception("Service not found");
            }
            
            if (descriptor.ServiceLifetime == ServiceLifetime.Singleton)
            {
                if (descriptor.Implementation == null)
                {
                    descriptor.Implementation = Activator.CreateInstance<T>();
                }
                
                return (T) descriptor.Implementation;
            }
            
            return Activator.CreateInstance<T>();
        }
    }
}