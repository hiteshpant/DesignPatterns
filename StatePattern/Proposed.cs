using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Proposed : BaseState, ICommand
    {

        public Proposed(WorkItem item) : base(item)
        {

        }
       

        public override void Delete(int id )
        {
            Console.WriteLine("Work Item in propsed state cannot be deleted");
        }

        public override string Edit(string state, string desc)
        {
            _Owner.Name = state;
            _Owner.Description = desc;
            return "Data Save Sucesfully";
        }

        public override void Print()
        {
            base.Print(_Owner);
        }

        internal override void SetState(string state)
        {
            switch (state)
            {
                case "Proposed":
                    {
                        Console.WriteLine("workitem is already in Proposed state");
                        break;
                    }
                case "Active":
                    {
                        _Owner.State = new Active(_Owner);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("workitem state  in Closed  state cannot be changed to " + state.GetType().Name);
                        break;
                    }                   
            }
        }
    }
}
