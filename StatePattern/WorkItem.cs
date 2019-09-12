using System;
using System.Linq;
namespace StatePattern
{
    public class WorkItem : ICommand
    {
        public string Name { get;  set; }
        public string Description { get;  set; }
        public BaseState State { get;  set; }
        public int Id { get;  set; }

        public Repository<WorkItem> Repository;


        public WorkItem()
        {
            Description = "<<New Bug Description>>";
            Id = new Random().Next();
            Name = "Bug" + Id;           
            State = new Proposed(this);     
        }

        public void Delete(int id)
        {
            if(State.GetType().Name=="Closed")
            {
                Repository.Remove(Repository.Items.FirstOrDefault(x => x.Id == id));
            }
        }

        public string Edit(string state, string desc)
        {
            return State.Edit(state, desc);
        }

        public void Print()
        {
            State.Print(this);
        }

        public void SetState(string input)
        {         
            State.SetState(input);
        }       
    }

    
}