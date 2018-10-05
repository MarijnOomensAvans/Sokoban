using System;

namespace SokoBan
{
    public class Sleeper : Movable
    {
        private bool _asleep = false;

        public Sleeper()
        {
            Type = 2;
        }

        public override bool CanMove(int direction)
        {
            if (OnTile.checkIfPMovableCanMove(direction))
            {
                return true;
            }

            return false;
        }

        public override void Move(int direction)
        {
            Tile tile = OnTile.moveMovable(direction);
            OnTile = tile;
        }

        public override char Print()
        {
            if (_asleep)
            {
                return 'Z';
            }

            return '$';
        }

        public void SleeperAction()
        {
            Random r = new Random();
            int randomNumber;
            if (!_asleep) // if awake
            {
                randomNumber = r.Next(1, 5);
                if (randomNumber == 4)
                {
                    _asleep = true; // go to sleep
                }
                else // if it didnt fall asleep
                {
                    randomNumber = r.Next(1, 5);
                    if (CanMove(randomNumber))
                    {
                        Move(randomNumber);
                    }
                }
            }
            else // if asleep
            {
                randomNumber = r.Next(1, 11);
                if (randomNumber == 8)
                {
                    _asleep = false; // wake up
                }
            }
        }
    }
}