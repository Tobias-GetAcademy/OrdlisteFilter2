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
        public List<Word> Words;

        public WordClass(string category, List<Word> ord)
        {
            Category = category;
            Words = ord;
        }

        public string GetStatisticsString()
        {
            Console.WriteLine(Category.Count().ToString());
            return Category.Count().ToString();
        }
    }
}
