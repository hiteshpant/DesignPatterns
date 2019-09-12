using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Closed : BaseState
    {
        public Closed(WorkItem item) :base(item)
        {

        }

        public override void Delete(int id)
        {
            Console.WriteLine("Item  deleted with id :"+ id);
        }

        public override string Edit(string state, string desc)
        {
            return "Data cannot be modified in closed state";
        }

        public override void Print()
        {
            base.Print(_Owner);
        }

        internal override void SetState(string state)
        {
            switch (state)
            {
                case "Closed":
                    {
                        Console.WriteLine("workitem is already in Closed state");
                        break;
                    }
                case "Active":
                    {
                        _Owner.State = new Active(_Owner);
                        break;
                    }
                case "Resolved":
                    {
                        _Owner.State = new Resolved(_Owner);
                        break;
                    }
                case "Proposed":
                    Console.WriteLine("workitem state  in Closed  state cannot be changed to " + state.GetType().Name);
                    break;
            }
        }
    }
}
