using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        Compare _compare = new Compare();

        Director _director = new Director();
        UserService _user = new UserService();
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
          int answer = _compare.getNumber();
          int guess = _director.GetInputs();

          if(answer == guess)
          {
            correctnumber = true;
            
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