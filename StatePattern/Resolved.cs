using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Resolved : BaseState
    {

        public Resolved(WorkItem item) : base(item)
        {

        }

        public override void Delete(int id)
        {
            Console.WriteLine("Deleted item succesfully");
        }

        public override string Edit(string state, string desc)
        {
            _Owner.Description = desc;
            _Owner.Name = state;
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
                case "Resolved":
                    {
                        Console.WriteLine("workitem is already in Resolved state");
                        break;
                    }
                case "Active":
                case "Closed":
                    {
                        _Owner.State = new Closed(_Owner);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("workitem state  in Resolved  state cannot be changed to " + state.GetType().Name);
                        break;
                    }
            }
        }
    }
}
