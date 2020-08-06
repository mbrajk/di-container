using System;
using System.Collections.Generic;
using DependencyInjection.Enums;

namespace DependencyInjection
{
    public class ServiceDescriptors
    {
        private readonly List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();

        public void AddSingleton(object implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(ServiceLifetime.Singleton, implementation));
        }

        public void AddTransient(object implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(ServiceLifetime.Transient, implementation));
        }

        public void AddSingleton<TInterface, TImplementation>(TInterface @interface, TImplementation implementation)
            where TImplementation : TInterface
        {
            throw new System.NotImplementedException();
        }

        public void AddTransient<TInterface, TImplementation>(TInterface @interface, TImplementation implementation)
            where TImplementation : TInterface
        {
            throw new System.NotImplementedException();
        }
        
        public ServiceContainer BuildServices()
        {
            //todo this should be a dictionary
            var availableServices = new ServiceContainer(_serviceDescriptors);

            // foreach (var serviceDescriptor in _serviceDescriptors)
            // {
            //     if (serviceDescriptor.ServiceLifetime == ServiceLifetime.Singleton)
            //     {
            //         if (serviceDescriptor.Implementation != null)
            //         {
            //             availableServices.Add(new ServiceDescriptor(
            //                 ServiceLifetime.Singleton,
            //                 serviceDescriptor.Implementation));
            //         }
            //         else
            //         {
            //             availableServices.Add(new ServiceDescriptor(
            //                 ServiceLifetime.Singleton,
            //                 Activator.CreateInstance(serviceDescriptor.Type)));
            //         }
            //     }
            //     
            //     //TODO: transient
            // }

            return availableServices;
        }
    }
}