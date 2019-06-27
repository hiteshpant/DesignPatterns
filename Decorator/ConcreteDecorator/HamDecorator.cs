using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza):base(pizza)
        {
            _Description = "Ham";
        }

        public override double CalcullateCost()
        {
            return _Pizza.CalcullateCost()+ 1.25;
        }

        public override string GetDescription()
        {
            return  string.Format("{0} {1}" ,_Pizza.GetDescription(),_Description);
        }
    }
}
