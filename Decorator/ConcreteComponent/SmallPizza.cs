﻿using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            _Description = "SmallPizza";
        }

        public override double CalcullateCost()
        {
            return 1.00;
        }

        public override string GetDescription()
        {
            return _Description;
        }
    }
}
