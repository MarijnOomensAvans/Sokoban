namespace SokoBan
{
    public class EndTile : Tile
    {
        public override Tile TileUp { get; set; }
        public override Tile TileDown { get; set; }
        public override Tile TileLeft { get; set; }
        public override Tile TileRight { get; set; }

        public override char Print()
        {
            if (HasMovable())
            {
                return Movable.Print();
            }

            return'x';
        }

        public override void MoveOver()
        {
        }
    }
}