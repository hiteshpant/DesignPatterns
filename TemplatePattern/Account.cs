using System;

namespace TemplatePattern
{
    public abstract class Template
    {
        public Template()
        {

        }

        public void  TemplatedMethod()
        {
            CallTemplatedClass1();
            CallTemplatedClass2();
        }

        public abstract void CallTemplatedClass1();

        public abstract void CallTemplatedClass2();
    }
}
