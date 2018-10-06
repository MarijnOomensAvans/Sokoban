namespace SokoBan
{
    public abstract class Movable
    {
        public Tile OnTile { get; set; }

        public abstract char Print();
        public virtual bool Move(int direction)
        {
            Tile tile = OnTile.moveMovable(direction);
            if (tile != null)
            {
                OnTile = tile;
                return true;
            }
            return false;
        }

    }
}