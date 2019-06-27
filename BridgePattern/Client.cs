using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            List<Docuent> documents = new List<Docuent>();
            IFormatter standardFormatter = new ReverseFormatter();
            var faq = new FAQ(standardFormatter)
            {
                Title = "The Bridge Pattern FAQ",
            };
            faq.Question.Add("What is it?", "A design pattern");
            faq.Question.Add("When to use", "When we want to seprate abstarction from implementaion");

            var book = new Book(standardFormatter)
            {
                Author = "abc",
                Title = "abc",
                Text = "blah blah blah"
            };

            var paper = new TermPaper(standardFormatter)
            {
                Class = "Nursery",
                References = "No reference",
                Student = "I am the student",
                Text = "Bridge pattern"
            };

            documents.Add(faq);
            documents.Add(book);
            documents.Add(paper);

            foreach (var document in documents)
            {
                document.Display();
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
