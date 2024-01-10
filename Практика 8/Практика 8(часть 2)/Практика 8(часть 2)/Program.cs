using System;
using System.Collections.Generic;

namespace Практика_8_часть_2_
{
    class Word
    {
        public string Origin { get; set; }
        public string Translate { get; set; }
        public Word(string origin, string translate)
        {
            Origin = origin;
            Translate = translate;
        }
    }
    class Dictionary
    {
        private IList<Word> _words = new List<Word>();
        public string this [string origin]
        {
            get => FindWord(origin).Translate;
            set => FindWord(origin).Translate = value;
        }
        public void AddWord(Word word) => _words.Add(word);
        private Word FindWord (string origin)
        {
            Word word = null;
            foreach (var item in _words)
                if (item.Origin == origin)
                {
                    word = item;
                    break;
                }
            return word;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.AddWord(new Word("Water", "Вода"));
            dictionary.AddWord(new Word("Fire", "Огонь"));
            Console.WriteLine(dictionary["Water"]);
            Console.WriteLine(dictionary["Fire"]);
        }
    }
}
