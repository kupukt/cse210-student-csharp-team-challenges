using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Word : Actor
    {   
        // private List<string> _words = new List<string>();
        Random randomGenerator = new Random();
        WordBank _wordBank = new WordBank();

        string newWord;

        public Word()
        {
            PrepareWord();
        }

        private void PrepareWord()
        {
            _text = _wordBank.generateWord();

            int x = Constants.MAX_X - 20;
            int y = randomGenerator.Next(10, Constants.MAX_Y - 25);

            int dx = randomGenerator.Next(1,4);
            int dy = 0;

            _position = new Point(x,y);
            _width = 0;
            _height = 0;

            _velocity = new Point(-dx,dy);
            
        }

        public void IsOffScreen()
        {
            
        }
    }
}