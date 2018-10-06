using System;

namespace SokoBan
{
    public abstract class Tile
    {
        public abstract Tile TileUp { get; set; }
        public abstract Tile TileDown { get; set; }
        public abstract Tile TileLeft { get; set; }
        public abstract Tile TileRight { get; set; }
        public Movable Movable { get; set; }
        public abstract char Print();

        public abstract bool MoveTo(Movable movable, int direction);

        internal Tile moveMovable(int direction)
        {
            Tile destination = null;
            switch (direction)
            {
                case 1:
                    destination = TileUp;
                    break;
                case 2:
                    destination = TileDown;
                    break;
                case 3:
                    destination = TileLeft;
                    break;
                case 4:
                    destination = TileRight;
                    break;
            }
            if (destination.Movable != null)
            {
                destination.Movable.Move(direction);
            }


            if (destination != null)
            {
                if (destination.MoveTo(Movable,direction)) {
                    Movable = null;
                    return destination;
                }
            }

            return null;
        }

        private void SetMovable(Movable movabable)
        {
            Movable = movabable;
        }



    }
}