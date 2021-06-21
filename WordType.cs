using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdlisteFilter.Functions
{
    class WordType
    {
        public string Value { get; }
        public IEnumerable<Word> Words => _words.ToArray();
        private List<Word> _words;

        public WordType(string value)
        {
            Value = value;
            _words = new List<Word>();
        }

        public void Add(Word word)
        {
            _words.Add(word);
        }

        public string GetStatisticsString()
        {
            return $"{Value} har {_words.Count} ord.";
        }
    }
}