using System;

namespace _06_mastermind
{
    public class Director
    {
        private UserService _userService = new UserService();
        private Compare _compare = new Compare();
        private Guess _guess = new Guess();
         private Roster _roster = new Roster();
        private Board _board = new Board();
        private bool _keepPlaying = true;
        public void StartGame()
        {
            PrepareGame();
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void PrepareGame()
        {
            for (int i =1; i <= 2; i++)
            {
                string prompt = $"Enter a name for  player {i}: ";
                string name = _userService.GetStringInput(prompt);

                Player player = new Player(name);
                _roster.AddPlayer(player);
            }
        }

        private void GetInputs()
        {
            string board = _board.ToString();
            _userService.DisplayText(board);

            Player currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn:");

            int guess = _userService.GetNumberInput("What is your guess? ");
            _guess.playerGuess(guess);
        }

        private void DoUpdates()
        {
            Player currentPlayer = _roster.GetCurrentPlayer();
        }

        private void DoOutputs()
        {
            if (_board.isCorrect())
            {
                Player winningPlayer = _roster.GetCurrentPlayer();
                string name = winningPlayer.GetName();

                _userService.DisplayText($"{name} won!");
                _keepPlaying = false;
            }

            _roster.AdvanceNextPlayer();

        }
    }
}