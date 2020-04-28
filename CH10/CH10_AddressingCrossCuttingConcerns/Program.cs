using CH10_AddressingCrossCuttingConcerns.DecoratorPattern;
using CH10_AddressingCrossCuttingConcerns.ProxyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_AddressingCrossCuttingConcerns
{
    class Program
    {
        static void Main(string[] args)
        {
            //DecoratorPatternExample();
            ProxyPatternExample();
            Console.ReadKey();
        }

        private static void DecoratorPatternExample()
        {
            var concreteComponent = new ConcreteComponent();
            var concreteDecorator = new ConcreteDecorator(concreteComponent);
            concreteDecorator.Operation();
        }

        private static void ProxyPatternExample()
        {
            Console.WriteLine("### Calling the Service directly. ###");
            var service = new Service();
            service.Request();

            Console.WriteLine("## Calling the Service via a Proxy. ###");
            new Proxy(service).Request();
        }
    }
}
