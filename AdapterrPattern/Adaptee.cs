using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterrPattern
{
    public class Adaptee
    {
        public void DoDavanceOperation(string initialValue)
        {
            Console.WriteLine(initialValue);
        }
    }
}
