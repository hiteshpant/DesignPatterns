using BuilderPattern.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder _Builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            _Builder = builder;
        }


        public Sandwich CreateSandwich()
        {
            _Builder.PrepareBread();
            _Builder.ApplyMeatAndCheese();
            _Builder.ApplyVegetables();
            _Builder.ApplyCondiments();
            return _Builder.GetSandwich();
        }
    }
}
