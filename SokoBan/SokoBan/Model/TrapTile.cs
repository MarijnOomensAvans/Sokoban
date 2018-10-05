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

        public void MoveOver()
        {
            _timesWalkedOver++;
        }
    }
}