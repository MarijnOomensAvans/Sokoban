using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Crate : Movable
    {
        public Crate(Tile t)
        {
            onTile = t;
        }

        public override bool CanMove(int direction)
        {
            if (onTile.checkIfCrateCanMove(direction))
            {
                return true;
            }

            return false;
        }

        public override void Move(int direction)
        {
            Tile tile = onTile.moveCrateTile(direction);
        }
    }
}