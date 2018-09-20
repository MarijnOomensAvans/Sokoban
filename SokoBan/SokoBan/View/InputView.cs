﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class InputView
    {
        public int WhichLevel()
        {
            Console.WriteLine("Kies een doolhof, s is stop");
            int mazeNumber = 0;
            char input = '?';
            while (((mazeNumber < 1) || (mazeNumber > 4)) && (input != 's'))
            {
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
    }
}