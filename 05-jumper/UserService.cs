using System;

namespace _05_jumper
{
    class User
    {
        public String GetLetter()
        {
            Console.Write("Guess a letter from [A-Z]:");
            String _guess = Console.ReadLine();
            return _guess;
            
        }
    }
}