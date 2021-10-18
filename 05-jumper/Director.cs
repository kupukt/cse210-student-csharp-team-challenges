using System;

namespace _05_jumper
{
    class Director
    {
        Jumper _jumper = new Jumper();
        User _user = new User();
        Words _words = new Words();
        WordBank _wordbank = new WordBank();


        bool _continuePlaying = true;
        string _letter;
        bool _correct;
        int _wrongGuesses = 0;
        public void StartGame()
        {
           SetupGame();

           while (_continuePlaying == true)
           {
               Inputs();
               Updates();
               Outputs();
           }
        }

        public void SetupGame()
        {
            _words.GetWord();
            _user.GetLetter();
            _jumper.DisplayParachute();

        }

        public void Inputs()
        {
            _letter = _user.GetLetter();

        }

        public void Updates()
        {
             
        }

        public void Outputs()
        {

        }
    }
}