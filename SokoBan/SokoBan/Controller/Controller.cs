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

            outputView.ShowStartScreen();
            mazeChoice = inputView.WhichLevel();
            if (mazeChoice == -1)
            {
                playing = false;
            }

            if (playing)
            {
                maze = parser.parseMaze(mazeChoice);
                outputView.ShowMaze(maze);
                bool resetting = true;
                while (resetting)
                {
                    int option = PlayMaze();
                    if (option == -1)
                    {
                        resetting = false;
                        outputView.ShowMaze(maze);
                        Console.Clear();
                        StartGame();
                    }

                    if (option == -2)
                    {
                        maze = parser.parseMaze(mazeChoice);
                        outputView.ShowMaze(maze);
                    }
                    if (option == 1)
                    {
                        resetting = false;
                        outputView.ShowMaze(maze);
                        outputView.ShowVictoryScreen();
                        Console.ReadKey();
                        Console.Clear();
                        StartGame();
                    }
                }
            }
        }

        private int PlayMaze()
        {
            bool levelFinished = false;
            int number = 0;
            while (!levelFinished)
            {
                int result = inputView.GetDirection();
                if (result == -2)
                {
                    return result;
                }

                if (result == -1)
                {
                    return result;
                }

                maze.movePlayer(result);
                if (maze.CheckGameWon())
                {
                    levelFinished = true;
                    Maze.CratesOnEndTiles = 0;
                    number = 1;
                }
                outputView.ShowMaze(maze);
            }

            return number;
        }
    }
}