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
            if (HasMovable())
            {
                if (GetMovableType() == 0)
                {
                    return '@';
                }

                if (GetMovableType() == 1)
                {
                    return 'o';
                }

                if (GetMovableType() == 2)
                {
                    if (Movable.State == 1)
                    {
                        return '$';
                    }

                    return 'Z';
                }
            }

            if (_timesWalkedOver >= 3)
            {
                return ' ';
            }

            return '~';
        }

        public override void MoveOver()
        {
            _timesWalkedOver++;
        }
    }
}