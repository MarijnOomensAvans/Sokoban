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

        public void ShowMaze()
        {
            Console.Clear();
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
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