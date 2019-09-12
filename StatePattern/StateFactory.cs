using System;
using System.Collections.Generic;
using System.Linq;

namespace StatePattern
{
    public static class StateFactory
    {
        public static List<String> GetAllState()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
               .Where(x => typeof(BaseState).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
               .Select(x => x.Name).ToList();
        }

        //public static BaseState GetSelectedState(string input)
        //{
        //    Activator.CreateInstance(input.GetType());           
        //}
    }
}