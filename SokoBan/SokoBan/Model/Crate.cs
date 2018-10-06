namespace SokoBan
{
    public class Crate : Movable
    {
        private bool _onEndTile;

        public Crate(Tile t)
        {
            OnTile = t;
        }

        public override bool Move(int direction)
        {
            Tile tile = OnTile.moveMovable(direction);
            if (tile != null)
            {
                //Typecheck
                if(tile is EndTile)
                {
                    _onEndTile = true;
                    Maze.CratesOnEndTiles++;
                }
                else if(_onEndTile)
                {
                    _onEndTile = false;
                    Maze.CratesOnEndTiles--;
                }
                OnTile = tile;
                return true;
            }
            return false;
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