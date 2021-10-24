using System;

namespace _06_mastermind{

    class Compare
    {
        
        private int _number;

        public int generateNumber()
        {
            Random randomgenerator = new Random();
            _number = 1234;
            return _number;
        }

        public int getNumber()
        {
            return _number;
        }

        public bool correctNumber(int guess)
        {
            bool correctnumber = true;
            if(guess != _number)
            {
                correctnumber = false;
            }
            return correctnumber;
        }

        public string generateHint(int guess)
        {
            string hint = "";
            string number = _number.ToString();
            string compareguess = guess.ToString();
            

            if (guess == 0)
            {
                hint = "****";
            }
            else
            {
                for (int i = 0; i<4; i++)
                {
                    if (compareguess[i] == number[i])
                    {
                        hint += "x";

                    }
                    else
                    {
                        for(int j = 0; j < 4; j++)
                        {
                            if(compareguess[i] == number[j] )
                            {
                                hint += "o";
                            }
                            else
                            {
                                hint += "*";
                            }
                        }
                       
                    }
                }
            }
            return hint;
        }
    }
}