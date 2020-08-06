using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup DI
            var serviceDescriptors = new ServiceDescriptors();

            // setup collection
            // serviceDescriptors.AddSingleton(new GuidGenerator());
                
            serviceDescriptors.AddTransient(new GuidGenerator());
            
            //TODO: AddSingleton<Interface, ConcreteImplementation>();
            //TODO: AddTransient<Interface, ConcreteImplementation>();
            
            // Build DI
            var services = serviceDescriptors.BuildServices();

            // Access DI'd item
            var guidGenerator1 = services.GetService<GuidGenerator>();
            var guidGenerator2 = services.GetService<GuidGenerator>();

            Console.WriteLine(guidGenerator1.RandomGuid);
            Console.WriteLine(guidGenerator2.RandomGuid);
        }
    }
}