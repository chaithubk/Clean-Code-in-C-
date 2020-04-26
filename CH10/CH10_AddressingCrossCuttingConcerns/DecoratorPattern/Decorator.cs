using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_AddressingCrossCuttingConcerns.DecoratorPattern
{
    public abstract class Decorator : Component
    {
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public virtual void Operation()
        {
            _component.Operation();
        }
    }
}
