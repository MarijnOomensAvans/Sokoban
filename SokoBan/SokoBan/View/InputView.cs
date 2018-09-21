using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SokoBan
{
    public class InputView
    {
        public int WhichLevel()
        {
            int mazeNumber = 0;
            char input = '?';
            while (((mazeNumber < 1) || (mazeNumber > 4)) && (input != 's'))
            {
                Console.WriteLine("Kies een doolhof (1-4), s is stop");
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                input = keyPressed.KeyChar;
                Console.WriteLine();
                if ((input >= '1') && (input <= '4'))
                {
                    mazeNumber = Convert.ToInt32(char.ToString(keyPressed.KeyChar));
                }
                else if (input != 's')
                {
                    Console.WriteLine("?");
                }
            }

            if (input == 's')
            {
                mazeNumber = -1;
            }
            return mazeNumber;
        }

        public int GetDirection()   //returns 1 for arrow up, 2 for arrow down, 3 for left, 4 for right
        {                           //returns -1 for S, and -2 for R
            bool pressed = false;
            int result = 0;
            while (!pressed)
            {
                ConsoleKey input = Console.ReadKey(false).Key;

                switch (input)
                {
                    case ConsoleKey.S:
                        result = - 1;
                        pressed = true;
                        break;
                    case ConsoleKey.R:
                        result = - 2;
                        pressed = true;
                        break;
                    case ConsoleKey.UpArrow:
                        result = 1;
                        pressed = true;
                        break;
                    case ConsoleKey.DownArrow:
                        result = 2;
                        pressed = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        result = 3;
                        pressed = true;
                        break;
                    case ConsoleKey.RightArrow:
                        result = 4;
                        pressed = true;
                        break;
                }
            }
            return result;
        }
    }
}