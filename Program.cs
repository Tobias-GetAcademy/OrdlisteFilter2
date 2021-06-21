using System;
using System.Collections.Generic;
using OrdlisteFilter.Functions;

namespace OrdlisteFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordList = new WordList("ordliste.txt");
            foreach (var wordType in wordList.WordTypes)
            {
                Console.WriteLine(wordType.GetStatisticsString());
            }
        }
    }
}