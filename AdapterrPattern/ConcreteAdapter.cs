using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterrPattern
{
    public class ConcreteAdapter : Adapter
    {
        private readonly Adaptee _Adaptee;
        public ConcreteAdapter()
        {
            _Adaptee = new Adaptee();
        }
        public override void Operation()
        {
            _Adaptee.DoDavanceOperation("Adapted to the incompatable class");
        }
    }
}
