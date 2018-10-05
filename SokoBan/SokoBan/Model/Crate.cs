namespace SokoBan
{
    public class Crate : Movable
    {

        public Crate(Tile t)
        {
            OnTile = t;
            Type = 1;
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
            Tile tile = OnTile.moveMovable(direction);
            OnTile = tile;
        }

        public override char Print()
        {
            return 'o';
        }
    }
}