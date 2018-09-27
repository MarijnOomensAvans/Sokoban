using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Player : Movable
    {

        public Player(Tile t)
        {
            onTile = t;
        }

        public override bool CanMove(int direction)
        {
            if (onTile.checkIfPlayerCanMove(direction))
            {
                return true;
            }

            return false;
        }

        public override void Move(int direction)
        {
            Tile tile = onTile.movePlayerTile(direction);
            onTile = tile;
        }
    }
}