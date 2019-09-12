using System;

namespace StatePattern
{
    public interface ICommand
    {
        void Delete(int id);

        string Edit(string state,string desc);

        void Print();
    }
}
