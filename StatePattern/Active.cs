using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Active : BaseState
    {

        public Active(WorkItem item) : base(item)
        {

        }
        public override void Delete(int id)
        {
            Console.WriteLine("Item is in Active, We cannot delete it");
        }

        public override string Edit(string state, string desc)
        {
            _Owner.Name = state;
            _Owner.Description = desc;
            return "Data Save Sucesfully";
        }

        public override void Print()
        {
            Print(_Owner);
        }

        internal override void SetState(string state)
        {
            switch (state)
            {
                case "Active":
                    {
                        Console.WriteLine("workitem is already in active state");
                        break;
                    }
                case "Proposed":
                case "Resolved":
                    {
                        _Owner.State = new Resolved(_Owner);
                        break;
                    }
                default:
                    Console.WriteLine("workitem state  in active state cannot be changed to " + state.GetType().Name);
                    break;
            }
        }
    }
}
