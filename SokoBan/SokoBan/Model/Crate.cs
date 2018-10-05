namespace SokoBan
{
    public class Crate : Movable
    {

        public Crate(Tile t)
        {
            OnTile = t;
        }

        public override bool Move(int direction)
        {
            Tile tile = OnTile.moveMovable(direction);
            OnTile = tile;
            return true;
        }

        public override char Print()
        {
            return 'o';
        }
    }
}