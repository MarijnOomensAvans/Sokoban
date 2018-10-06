namespace SokoBan
{
    public class Player : Movable
    {

        public Player(Tile t)
        {
            OnTile = t;
        }

        public override char Print()
        {
            return '@';
        }
    }
}