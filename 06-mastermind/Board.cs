using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        Compare _compare = new Compare();

        Director _director = new Director();
        UserService _user = new UserService();

        Player _player = new Player();
             
        public Board()
        {

        }

        
        public bool isCorrect()
        {
          bool correctnumber = false;
          int answer = _compare.getNumber();
          int guess = _player.getGuess();

          if(answer == guess)
          {
            correctnumber = true;
            
          }
            return correctnumber;
        }

        public override String ToString()
        {
            string text = $"\n--------------------\n";
                    text += $"Player";

            return text;
            
        }  
    }
}