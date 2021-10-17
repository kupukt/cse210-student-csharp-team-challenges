using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class WordBank
    {
        
        
        public string wordGenerator()
        {
            List<string> _wordbank = new List<string>();
            Random wordsgenerator = new Random();
           
            _wordbank.Add("Tacos");
            _wordbank.Add("Lacrosse");
            _wordbank.Add("Apocolypse");
            _wordbank.Add("Strawberry");

            string _word = _wordbank[wordsgenerator.Next(1,_wordbank.Count)];

            return _word;

            
        }

    }
}
