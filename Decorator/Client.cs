using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Client
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new ChesseDecorator(largePizza);
            largePizza = new HamDecorator(largePizza);

            Console.WriteLine( largePizza.GetDescription());
            Console.WriteLine("{0:C2}",largePizza.CalcullateCost());

            Console.ReadLine();
        }
    }
}
