using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Interface
{
    public abstract class Docuent
    {
        protected IFormatter _Formatter;
        public Docuent(IFormatter formatter)
        {
            _Formatter = formatter;
        }

        public abstract void Display();
    }
}
