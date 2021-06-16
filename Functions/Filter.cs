using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace OrdlisteFilter.Functions
{
    class Filter
    {
        private const string FilePath = "C:\\Users\\Tobias-Tofsland\\source\\repos\\OrdlisteFilter\\ordliste.txt";
        public static List<WordClass> WordList = new List<WordClass>();
        public static void WordClasses(string useInput)
        {
            AddWordsToList();
            while (true)
            {
                FindWordInCategory();

                useInput = Console.ReadLine();
            }
        }

        public static void AddWordsToList()
        {
            foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
            {
                var parts = line.Split('\t');
                var word = parts[2];

                var isWordClass = parts[3];

                var acctualWordClass = isWordClass.Split(' ');

                WordList.Add(new WordClass(acctualWordClass[0], word));

            }
            System.Console.WriteLine(WordList.Count);
            //Console.WriteLine(WordList[2].Category);
            //Console.WriteLine(WordList[2].Word);
            //Console.WriteLine(WordList.Count);
        }

        public static void FindWordInCategory()
        {
            List<string> ordKlasser = new List<string>();
            foreach (var word in WordList)
            {
                if (!ordKlasser.Contains(word.Category) && !word.Category.Contains('+'))
                {
                    ordKlasser.Add(word.Category);
                }
            }
            ordKlasser.ForEach(Console.WriteLine);

            var currentCategory = "";

            foreach (var ord in ordKlasser)
            {
                currentCategory = ord;
                var counter = 0;
                var wordInCategory = WordList.FindAll(word => word.Category == ord);
                foreach (var word in wordInCategory)
                {
                    counter++;
                }
                System.Console.WriteLine("Det er såååå mange " + currentCategory + " " + counter + " i listen.");
                System.Console.WriteLine();
            }
        }
    }
}