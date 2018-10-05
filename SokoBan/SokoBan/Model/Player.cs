namespace SokoBan
{
    public class Player : Movable
    {

        public Player(Tile t)
        {
            OnTile = t;
            Type = 0;
        }

        public override bool CanMove(int direction)
        {
            if (OnTile.checkIfPMovableCanMove(direction))
            {
                return true;
            }

            return false;
        }

        public override void Move(int direction)
        {
            Tile Tile = OnTile.moveMovable(direction);
            OnTile = Tile;
        }

        public override char Print()
        {
            return '@';
        }
    }
}