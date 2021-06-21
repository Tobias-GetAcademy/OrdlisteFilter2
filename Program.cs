using System;
using System.Collections.Generic;
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
            var wordList = new WordList("ordliste.txt");
            IEnumerable<WordClass> wordClasses = wordList.GetWordClasses();
            foreach (var wordClass in wordClasses) // hvis du har 6 ordklasser, så går den igjennom hver av dem og skriver ut statistikken
            {
                Console.WriteLine(wordClass.GetStatisticsString() + " hei");
            }
        }
    }
}
