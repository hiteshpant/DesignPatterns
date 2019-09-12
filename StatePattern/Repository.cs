using System.Collections.Generic;

namespace StatePattern
{
    public class Repository<T> where T:class
    {
        public List<T> Items { get; set; }

        public Repository()
        {
            Items = new List<T>();
        }

        public void Add(T Item)
        {
            Items.Add(Item);
        }

        public bool Remove(T Item)
        {
           return  Items.Remove(Item);
        }
    }
}