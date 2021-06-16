using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdlisteFilter
{
    class WordClass
    {
        public string Category { get; set; }
        public string Word { get; set; }

        public WordClass(string category, string word)
        {
            Category = category;
            Word = word;
        }
    }
}
