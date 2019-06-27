using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregator.Interface
{


    public delegate void EventHandler<T>(object sender, MyEventArgs<T> args);

   
    public class MyEventArgs<T> : EventArgs
    {
        public T Item { get; set; }

        public MyEventArgs(T item)
        {
            Item = item;
        }
    }


    public class SimpleEventAggregator<T> : IEventAggregator<T>
    {      

        private Dictionary<string, EventHandler<T>> _Events = new Dictionary<string, EventHandler<T>>();

        public void PublishEvent(string name, EventHandler<T> handler,object sender, MyEventArgs<T> args)
        {
            if (!_Events.ContainsKey(name))
            {
                _Events[name] = handler;
            }
            else
                _Events[name](sender, args);
        }

        public void SubscribeEvent(string name, EventHandler<T> handler)
        {
            if (_Events.ContainsKey(name))
                _Events[name] += handler;
        }
    }
}
