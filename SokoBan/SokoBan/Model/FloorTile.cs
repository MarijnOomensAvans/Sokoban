﻿namespace SokoBan
{
    public class FloorTile : Tile
    {
        public override Tile TileUp { get; set; }
        public override Tile TileDown { get; set; }
        public override Tile TileLeft { get; set; }
        public override Tile TileRight { get; set; }

        public override bool MoveTo(Movable movable, int direction)
        {
            //Type check
            if (movable is Crate)
            {
                if(Movable != null)
                {
                    return false;
                }
            }
            //Type check
            if(Movable is Sleeper)
            {
                return false;
            }
            if (Movable != null)
            {
                if (Movable.Move(direction))
                {
                    Movable = movable;
                    return true;
                }
                return false;
            }
            Movable = movable;
            return true;

        }

        public override char Print()
        {
            if (Movable != null)
            {
                return Movable.Print();
            }

            return '.';
        }
    }
}