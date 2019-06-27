using BridgePattern.Interface;
using System.Linq;

namespace BridgePattern
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0} : {1}",key, new string(value.Reverse().ToArray()));
        }
    }
}
