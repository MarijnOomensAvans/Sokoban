namespace SokoBan
{
    public class TrapTile : Tile
    {
        public override Tile TileUp { get;set; }
        public override Tile TileDown { get; set; }
        public override Tile TileLeft { get; set; }
        public override Tile TileRight { get; set; }
        private int _timesWalkedOver = 0;

        public override char Print()
        {
            if (Movable != null)
            {
                return Movable.Print();
            }

            if (_timesWalkedOver >= 3)
            {
                return ' ';
            }

            return '~';
        }

        public override bool MoveTo(Movable movable, int direction)
        {
            if (Movable != null)
            {
                if (Movable.Move(direction))
                {
                    Movable = movable;
                    _timesWalkedOver++;
                    return true;
                }
                else return false;
            }
            if (movable.Print() == 'o' && _timesWalkedOver >= 3)
            {
                Movable = null;
                return true;
            }
            Movable = movable;
            _timesWalkedOver++;
            return true;
        }
    }
}