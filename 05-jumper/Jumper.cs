using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Jumper
    {
        List<char> _underscore = new List<char>(); 
        WordBank _WordBank = new WordBank();
        int _wrongGuess = 0;
        
        char[,] _parachute = new char[7 , 5] {
                {' ', '_', '_', '_', ' '},
                {'/', '_', '_', '_', '\\'},
                {'\\', ' ', ' ', ' ', '/'},
                {' ', '\\', ' ', '/', ' '},
                {' ', ' ', '0', ' ', ' '},
                {' ', '/', '|', '\\', ' '},
                {' ', '/', ' ', '\\', ' '}};

        public void DisplayParachute()
        {
            for (int row = _wrongGuess; row < 7; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write($"{_parachute[row , col]}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^^^^^^^");
           
        }

        public int CutParachute()
        {
            return _wrongGuess++;
        }
    }
}

