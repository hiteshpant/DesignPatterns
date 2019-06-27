using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Sandwich
    {
        public CheeseType CheeseType { get; set; }
        public BreadType BreadType { get; set; }
        public bool HasMayo { get; set; }
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public List<string> Vegetables { get; set; }

        public Sandwich()
        {

        }

    }


    public enum CheeseType
    {
        Cheddar,
        Parmesan
    }

    public enum BreadType
    {
        BrownBread,
        WhiteBread
    }
}
