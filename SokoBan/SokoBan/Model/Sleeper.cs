using System;

namespace SokoBan
{
    public class Sleeper : Movable
    {

        public bool Asleep { get; set; }

        public Sleeper()
        {
            Asleep = false;
        }

        public override bool Move(int direction)
        {
            Tile tile = OnTile.moveMovable(direction);
            OnTile = tile;
            return true;
        }

        public override char Print()
        {
            if (Asleep)
            {
                return 'Z';
            }

            return '$';
        }

        public void SleeperAction()
        {
            Random r = new Random();
            int randomNumber;
            if (!Asleep) // if awake
            {
                randomNumber = r.Next(1, 5);
                if (randomNumber == 4)
                {
                    Asleep = true; // go to sleep
                }
                else // if it didnt fall asleep
                {
                    randomNumber = r.Next(1, 5);
                    Move(randomNumber);

                }
            }
            else // if asleep
            {
                randomNumber = r.Next(1, 11);
                if (randomNumber == 8)
                {
                    Asleep = false; // wake up
                }
            }
        }
    }
}