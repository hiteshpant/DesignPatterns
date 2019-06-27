using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class ChesseDecorator : PizzaDecorator
    {
        public ChesseDecorator(Pizza pizza):base(pizza)
        {
            _Description = "Cheese";
        }

        public override double CalcullateCost()
        {
            return _Pizza.CalcullateCost() + 0.75;
        }

        public override string GetDescription()
        {

            return string.Format("{0},  {1}", _Pizza.GetDescription(), _Description);
        }
    }
}
