using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class FAQ : Docuent
    {

        public FAQ(IFormatter formatter) : base(formatter) { }

        public string Title { get; set; }
        public Dictionary<string, string> Question { get; set; } = new Dictionary<string, string>();

        public override void Display()
        {
            Console.WriteLine("Title: " + Title);
            int questionNo = 0;
            foreach (var question in Question)
            {
                questionNo++;
                Console.WriteLine("Question  : " + questionNo +_Formatter.Format( question.Key ,question.Value));
            }

        }
    }
}
