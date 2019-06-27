using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public abstract class Pizza
    {
        protected string _Description { get; set; }
        
        public abstract double CalcullateCost();

        public abstract string GetDescription();
    }
}
