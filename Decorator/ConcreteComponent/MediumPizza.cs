using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            _Description = "MediumPizza";
        }
        public override double CalcullateCost()
        {
            return 2.00;
        }

        public override string GetDescription()
        {
            return _Description;
        }
    }
}
