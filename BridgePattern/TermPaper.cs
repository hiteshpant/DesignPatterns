using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class TermPaper:Docuent
    {

        public TermPaper(IFormatter formatter) : base(formatter) { }

        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public override void Display()
        {
            Console.WriteLine(_Formatter.Format("Class", Class));
            Console.WriteLine(_Formatter.Format("Student", Student));
            Console.WriteLine(_Formatter.Format("Text", Text));
            Console.WriteLine(_Formatter.Format("References", References));
        }
    }
}
