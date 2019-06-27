using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            _Description = "LargePizza";
        }

        public override double CalcullateCost()
        {
            return 3.00;
        }

        public override string GetDescription()
        {
            return base._Description;
        }
    }
}
