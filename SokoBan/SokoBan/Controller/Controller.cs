using System;

namespace SokoBan
{
    public class Controller
    {
        private InputView InputView;
        private OutputView OutputView;
        private Maze Maze;

        public Controller()
        {
            InputView = new InputView();
            OutputView = new OutputView();
            StartGame();
        }

        private void StartGame()
        {
            Parser Parser = new Parser();
            bool Playing = true;
            int MazeChoice = 0;

            OutputView.ShowStartScreen();
            MazeChoice = InputView.WhichLevel();
            if (MazeChoice == -1)
            {
                Playing = false;
            }

            if (Playing)
            {
                Maze = Parser.parseMaze(MazeChoice);
                OutputView.ShowMaze(Maze);
                bool Resetting = true;
                while (Resetting)
                {
                    int Option = PlayMaze();
                    if (Option == -1)
                    {
                        Resetting = false;
                        OutputView.ShowMaze(Maze);
                        Console.Clear();
                        StartGame();
                    }

                    if (Option == -2)
                    {
                        Maze = Parser.parseMaze(MazeChoice);
                        OutputView.ShowMaze(Maze);
                    }
                    if (Option == 1)
                    {
                        Resetting = false;
                        OutputView.ShowMaze(Maze);
                        OutputView.ShowVictoryScreen();
                        Console.ReadKey();
                        Console.Clear();
                        StartGame();
                    }
                }
            }
        }

        private int PlayMaze()
        {
            bool LevelFinished = false;
            int Number = 0;
            while (!LevelFinished)
            {
                int Result = InputView.GetDirection();
                if (Result == -2)
                {
                    return Result;
                }

                if (Result == -1)
                {
                    return Result;
                }

                Maze.movePlayer(Result);
                if (Maze.CheckGameWon())
                {
                    LevelFinished = true;
                    Maze.CratesOnEndTiles = 0;
                    Number = 1;
                }
                OutputView.ShowMaze(Maze);
            }

            return Number;
        }
    }
}