using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Properties
{
    public abstract class SandwichBuilder
    {
        protected Sandwich _Sandwich;

        public Sandwich GetSandwich()
        {
            return _Sandwich;
        }

        public abstract void PrepareBread();

        public abstract void ApplyMeatAndCheese();

        public abstract void ApplyVegetables();

        public abstract void ApplyCondiments();
    }
}
