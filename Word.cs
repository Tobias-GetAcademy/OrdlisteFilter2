namespace OrdlisteFilter.Functions
{
    class Word
    {
        public string Value { get; set; }
        public WordType WordType { get; set; }

        public Word(string value, WordType wordType)
        {
            Value = value;
            WordType = wordType;
        }
    }
}