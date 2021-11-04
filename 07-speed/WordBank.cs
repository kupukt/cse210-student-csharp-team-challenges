using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    public class WordBank
    {

        private List<string> _words = new List<string>();
        Random randomGenerator = new Random();

        public WordBank()
        {
            AddToWord();
        }
        public void AddToWord()
        {
            _words.Add("Bat");
            _words.Add("Moroni");
            _words.Add("Kupu");
            _words.Add("Rainbow");
            _words.Add("Computer");
            _words.Add("Hypertonic");
            _words.Add("octopus");
            _words.Add("bird");
            _words.Add("Hawaii");
            _words.Add("Cologne");
            _words.Add("Stars");
            _words.Add("Heaven");
            _words.Add("Anime");
    
        }

        public string generateWord()
        {
            string word = _words[randomGenerator.Next(0, _words.Count - 1)];

            
            return word;
        }

        public List<string> getWords()
        {
            return _words; 
        }

    }
}