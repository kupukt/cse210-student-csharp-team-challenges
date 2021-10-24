using System;

namespace _06_mastermind
{
    
    class Player
    {
        private string _name;
        public int guess;

        
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
            
            Console.WriteLine("What is your guess?");
            string input = Console.ReadLine();
            int guess = int.Parse(input);
            return guess;
        }
    }
}
