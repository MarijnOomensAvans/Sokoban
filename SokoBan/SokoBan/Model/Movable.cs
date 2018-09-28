namespace SokoBan
{
    public abstract class Movable
    {
        public Tile onTile { get; set; }
        public int Type { get; set; }
        public int State { get; set; }
        public int TimesWalkedOver { get; set; } = 0;

        public abstract bool CanMove(int direction);
        public abstract void Move(int direction);
    }
}