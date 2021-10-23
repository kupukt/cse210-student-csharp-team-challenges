using System;

namespace _06_mastermind
{
    /// <summary>
    /// Contains the pile and the number of stones for a given move.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Guess
    {
        int[] _playerguess = new int[2];
        int _turn = 0;

        //Gets the turn and saves it to the player
        
        public void playerGuess(int playerguess)
        {
           _playerguess[_turn] = playerguess;
        }

        public int[] getGuess()
        {
            return _playerguess;
                  
        }
    }
}