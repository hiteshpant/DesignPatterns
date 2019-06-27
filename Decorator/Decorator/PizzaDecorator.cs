using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _Pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _Pizza = pizza;
        }

        public override double CalcullateCost()
        {
            return _Pizza.CalcullateCost();
        }

        public override string GetDescription()
        {

            return _Pizza.GetDescription();
        }
    }
}
