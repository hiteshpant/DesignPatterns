using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public abstract class BaseState: ICommand
    {
        protected WorkItem _Owner;

        public BaseState(WorkItem item)
        {
            _Owner = item;
        }

        public abstract void Delete(int id);
        public abstract string Edit(string state, string desc);
        public abstract void Print();
        internal abstract void SetState(string state);

        public  void Print(WorkItem workitem)
        {
            Console.WriteLine("Workitem ID: "+workitem.Id);
            Console.WriteLine("Workitem Name: " + workitem.Name);
            Console.WriteLine("Workitem Description: " + workitem.Description);
            Console.WriteLine("Workitem State: " + workitem.State);

        }

        public static explicit operator BaseState(Type v)
        {
            throw new NotImplementedException();
        }
    }
}
