using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        private Guess _guess = new Guess();
        private Compare _compare = new Compare();
        List<string> _info = new List<string>();
        int _turn = 0;
        public Board()
        {

        }

        // --------------------
        // Player Matt: 1111, xooo
        // Player John: ----, ****
        // --------------------
        // John's turn:
        // What is your guess? 4356
        // 

        public bool isCorrect()
        {
            bool correctnumber = false;
            int [] guesses = _guess.getGuess();
            if (_turn == 0)
            {
                _compare.correctNumber(guesses[0]);
                _turn = 1;
            }
            else
            {
                _compare.correctNumber(guesses[1]);
                _turn = 0;
            }

            return correctnumber;
        }

        public override String ToString()
        {
            string text = $"\n--------------------\n";

            return text;
            
        }  
    }
}