using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Controller
    {
        private InputView inputView;
        private OutputView outputView;
        private Maze maze;

        public Controller()
        {
            inputView = new InputView();
            outputView = new OutputView();
            StartGame();
        }

        private void StartGame()
        {
            Parser parser = new Parser();
            bool playing = true;
            int mazeChoice = 0;
            int number = 0;
            while (playing)
            {
                if (number == 0)
                {
                    outputView.ShowStartScreen();
                    mazeChoice = inputView.WhichLevel();
                    if (mazeChoice == -1)
                    {
                        playing = false;
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}