using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrdlisteFilter.Functions
{
    class WordList
    {
        public string FilePath { get; set; }
        public List<WordList> wordList = new List<WordList>();

    public WordList(string ordlisteTxt)
        {
            FilePath = ordlisteTxt;
        }

        public void WordClasses(string useInput)
        {
            //AddWordsToList();
            while (true)
            {
                GetWordClasses();

                useInput = Console.ReadLine();
            }
        }

        public IEnumerable<WordClass> GetWordClasses()
        {
            List<WordClass> wordClasses = new List<WordClass>();

            foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
            {
                var parts = line.Split('\t');
                var word = parts[2]; // word til word class

                var isWordClass = parts[3]; // world class category

                var acctualWordClass = isWordClass.Split(' ');
                wordList.Add(new WordList(word));
            }

            Console.WriteLine(wordList[34]);

            Console.WriteLine(wordClasses.Count);
            int count = 0;
            foreach (var word in wordList) count++;
            Console.WriteLine(count.ToString());
            return wordClasses;
        }

        //public void FindWordInCategory()
        //{
        //    List<string> ordKlasser = new List<string>();
        //    foreach (var word in wordList)
        //    {
        //        if (!ordKlasser.Contains(word.) && !word.Ord.Contains('+'))
        //        {
        //            ordKlasser.Add(word);
        //        }
        //    }

        //    ordKlasser.ForEach(Console.WriteLine);

        //    var currentCategory = "";

        //    foreach (var ord in ordKlasser)
        //    {
        //        currentCategory = ord;
        //        var counter = 0;
        //        var wordInCategory = wordList.FindAll(word => word.Ord == ord);
        //        foreach (var word in wordInCategory)
        //        {
        //            counter++;
        //        }
        //        System.Console.WriteLine("Det er såååå mange " + currentCategory + " " + counter + " i listen.");
        //        System.Console.WriteLine();
        //    }

        //    Console.WriteLine();
        //}

    }
}
