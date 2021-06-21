using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdlisteFilter
{
    class Word
    {
        public string Ord { get; set; }
        public WordClass WordClass;

        public Word(string word, WordClass wordClass)
        {
            Ord = word;
            WordClass = wordClass;

        }
    }
}
