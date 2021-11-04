using System;

namespace _06_mastermind
{
    
    class Player
    {
        private string _name;
        public int _guess;

        
        public Player(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public int getGuess()
        {
           
            return _guess;
        }

        public void setGuess(int guess)
        {
            _guess = guess;
        }
          
    }
}
