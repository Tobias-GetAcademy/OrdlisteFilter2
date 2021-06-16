using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using OrdlisteFilter.Functions;

namespace OrdlisteFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type:\n subst = substantiv,\n adv = adverb,\n verb = verb,\n adj = adjektiv,\n det = determinativ,\n exit");
            var useInput = Console.ReadLine();
            Filter.WordClasses(useInput);
        }
    }
}
