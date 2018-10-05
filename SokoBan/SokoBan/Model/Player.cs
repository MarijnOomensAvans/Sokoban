namespace SokoBan
{
    public class Player : Movable
    {

        public Player(Tile t)
        {
            OnTile = t;
        }

        public override bool Move(int direction)
        {
            Tile Tile = OnTile.moveMovable(direction);
            OnTile = Tile;
            return true;
        }

        public override char Print()
        {
            return '@';
        }
    }
}