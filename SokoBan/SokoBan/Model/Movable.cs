namespace SokoBan
{
    public abstract class Movable
    {
        public Tile OnTile { get; set; }

        public abstract char Print();
        public abstract bool Move(int direction);
    }
}