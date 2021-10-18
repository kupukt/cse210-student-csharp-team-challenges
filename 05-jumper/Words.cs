using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_jumper
{
    class Words
    {
        String _secretword;
        WordBank _wordbank = new WordBank();
        User _user = new User();

        public string GetWord()
        {
            _secretword = _wordbank.wordGenerator();

            return _secretword;
        }

        
        public String DisplayWord()
        {
           String _guess = _user.GetLetter();
           Char[] _charguess = _guess.ToCharArray();

           _charguess = new Char[_secretword.Length]; 
 
            for (int i = 0; i < _secretword.Length; i++)
                _charguess[i] = '_';
 
            while (true)
            {
                char _playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < _secretword.Length; j++)
                {
                    if (_playerGuess == _secretword[j])
                        _charguess[j] = _playerGuess;
                }
                Console.WriteLine(_charguess);    
            }
        }
        
    }
}
