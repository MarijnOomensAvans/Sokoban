namespace SokoBan
{
    public abstract class Movable
    {
        public Tile OnTile { get; set; }
        public int Type { get; set; }
        public int State { get; set; }

        public abstract char Print();
        public abstract bool CanMove(int direction);
        public abstract void Move(int direction);
    }
}