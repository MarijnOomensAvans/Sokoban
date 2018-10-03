using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class FloorTile : Tile
    {
        public override Tile TileUp { get; set; }
        public override Tile TileDown { get; set; }
        public override Tile TileLeft { get; set; }
        public override Tile TileRight { get; set; }

        public override char Print()
        {
            if (HasMovable())
            {
                if (GetMovableType() == 0)
                {
                    return '@';
                }

                if (GetMovableType() == 1)
                {
                    return 'o';
                }

                if (GetMovableType() == 2)
                {
                    if (Movable.State == 1)
                    {
                        return '$';
                    }

                    return 'Z';
                }
            }

            return '.';
        }
        public override void MoveOver()
        {
        }
    }
}