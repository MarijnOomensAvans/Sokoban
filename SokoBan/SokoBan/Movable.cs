namespace SokoBan
{
    public abstract class Movable
    {
        public Tile onTile { get; set; }

        public abstract bool CanMove(int direction);
        public abstract void Move(int direction);
    }
}