using System;

namespace SokoBan
{
    public class Sleeper : Movable
    {
        public Sleeper()
        {
            State = 1; // state 1 is awake, state 2 is asleep
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

        public void SleeperAction()
        {
            Random r = new Random();
            int randomNumber;
            if (State == 1) // if awake
            {
                randomNumber = r.Next(1, 5);
                if (randomNumber == 4)
                {
                    State = 2; // go to sleep
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
                    State = 1; // wake up
                }
            }
        }
    }
}