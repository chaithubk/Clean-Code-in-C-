using CH10_AddressingCrossCuttingConcerns.DecoratorPattern;
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
            DecoratorPatternExample();
            Console.ReadKey();
        }

        private static void DecoratorPatternExample()
        {
            var concreteComponent = new ConcreteComponent();
            var concreteDecorator = new ConcreteDecorator(concreteComponent);
            concreteDecorator.Operation();
        }
    }
}
