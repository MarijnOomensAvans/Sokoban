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
            Type = 0;
        }

        public override bool CanMove(int direction)
        {
            if (onTile.checkIfPMovableCanMove(direction))
            {
                return true;
            }

            return false;
        }

        public override void Move(int direction)
        {
            Tile tile = onTile.moveMovable(direction);
            if (tile.Print() == '~' || tile.Print() == ' ')
            {
                tile.MoveOver();
            }
            onTile = tile;
        }
    }
}