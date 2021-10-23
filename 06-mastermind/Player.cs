using System;

namespace _06_mastermind
{
    
    class Player
    {
        private string _name;
        private Guess _guess;

        
        public Player(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetGuess(Guess guess)
        {
            _guess = guess;
        }

        public Guess GetGuess()
        {
            return _guess;
        }
    }
}