using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregator.Interface
{
    public interface IEventAggregator<T>
    {
        void PublishEvent(string name, EventHandler<T> handler, object sender, MyEventArgs<T> args);


        void SubscribeEvent(string name, EventHandler<T> handler);
        

    }
}
