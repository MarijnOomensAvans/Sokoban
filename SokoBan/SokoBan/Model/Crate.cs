namespace SokoBan
{
    public class Crate : Movable
    {
        private bool _onEndTile;

        public Crate(Tile t)
        {
            OnTile = t;
        }

        public void setOnEndTile(bool onEndTile)
        {
            _onEndTile = onEndTile;
        }

        public override char Print()
        {
            if(_onEndTile)
            {
                return '0';
            }
            return 'o';
        }
    }
}