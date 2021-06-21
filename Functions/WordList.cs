using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrdlisteFilter.Functions
{
    class WordList
    {
        public IEnumerable<WordType> WordTypes => _wordTypes.ToArray();

        private List<WordType> _wordTypes;
        private List<Word> _words;

        public WordList(string fileName)
        {
            _wordTypes = new List<WordType>();
            _words = new List<Word>();
            var i = 0;

            foreach (var line in File.ReadLines(fileName, Encoding.UTF8))
            {

                i++;
                if (i % 5000 == 0) Console.Write(".");
                var parts = line.Split('\t', ' ');
                var wordStr = parts[2]; // word til word class
                var wordTypeStr = parts[3]; // world class category
                var wordType = FindOrCreateWordType(wordTypeStr);
                var word = new Word(wordStr, wordType);
                if (!wordTypeStr.Contains(word.Value) && !word.Value.Contains('+'))
                {
                    //_words.Add(word);
                    wordType.Add(word);
                }

            }

            Console.Clear();
        }

        private WordType FindOrCreateWordType(string wordTypeStr)
        {
            var wordType = _wordTypes.SingleOrDefault(wt => wt.Value == wordTypeStr);
            if (wordType == null)
            {
                wordType = new WordType(wordTypeStr);
                _wordTypes.Add(wordType);
            }

            return wordType;
        }


    }
}