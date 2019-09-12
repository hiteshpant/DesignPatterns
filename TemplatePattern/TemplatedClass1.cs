using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class TemplatedClass1 : Template
    {
        public TemplatedClass1()
        {
        }

        public override void CallTemplatedClass1()
        {
            throw new NotImplementedException();
        }

        public override void CallTemplatedClass2()
        {
            throw new NotImplementedException();
        }
    }
}
