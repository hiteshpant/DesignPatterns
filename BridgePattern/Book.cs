using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Book : Docuent
    {

        public Book(IFormatter formatter) : base(formatter) { }
        
        public string Author { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public override void Display()
        {
            Console.WriteLine(_Formatter.Format("Tittle",Title));
            Console.WriteLine(_Formatter.Format("Text", Text));
            Console.WriteLine("Title" + Title);
        }
    }
}
