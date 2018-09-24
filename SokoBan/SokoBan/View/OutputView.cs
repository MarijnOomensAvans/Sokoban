using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class OutputView
    {
        public void ShowStartScreen()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("|     Welkom bij Sokoban.                                    |");
            Console.WriteLine("|                                  |                         |");
            Console.WriteLine("|     Betekenis van de symbolen.   |   doel van het spel     |");
            Console.WriteLine("|                                  |                         |");
            Console.WriteLine("|     spatie : outerspace          |   duw met de tuck       |");
            Console.WriteLine("|          # : muur                |   de krat(ten)          |");
            Console.WriteLine("|          . : vloer               |   naar de bestemming    |");
            Console.WriteLine("|          o : krat                |                         |");
            Console.WriteLine("|          0 : krat op bestemming  |                         |");
            Console.WriteLine("|          x : bestemming          |                         |");
            Console.WriteLine("|          @ : truck               |                         |");
            Console.WriteLine("|          ~ : valkuil             |                         |");
            Console.WriteLine("|____________________________________________________________|");
            Console.WriteLine();
        }

        public void ShowMaze(Maze maze)
        {
            Console.Clear();
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            DrawMaze(maze);
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
        }

        private void DrawMaze(Maze Maze)
        {
            Tile Origin = Maze.OriginPoint;
            Tile BelowOrigin = Maze.OriginPoint.TileDown;
            for (int i = 0; i < Maze.Height; i++)
            {
                for (int j = 0; j < Maze.Width; j++)
                {
                    switch (Origin.GetType().ToString())
                    {
                        case "FloorTile":
                            if (Origin.hasCrate())
                            {
                                Console.Write("o");
                            }
                            else if(Origin.hasPlayer())
                            {
                                Console.Write("@");
                            }
                            else
                            {
                                Console.Write("/x00b7");
                            }
                            break;

                        case "Wall":
                            Console.Write("#");
                            break;
                        case "EndTile":
                            if (Origin.hasCrate())
                            {
                                Console.Write("0");
                            }
                            else if (Origin.hasPlayer())
                            {
                                Console.Write("@");
                            }
                            else
                            {
                                Console.Write("x");
                            }

                            break;
                        case "EmptyTile":
                            Console.Write(" ");
                            break;
                        default:
                            Console.Write("?");
                            break;
                    }

                    Origin = Origin.TileRight;
                }

                Origin = BelowOrigin;
                if (BelowOrigin != null)
                {
                    BelowOrigin = Origin.TileDown;
                }
            }

        }

        public void ShowVictoryScreen()
        {
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("");
            Console.WriteLine("=== HOERA OPGELOST ===");
            Console.WriteLine("press key to continue");
        }
    }
}