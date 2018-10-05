namespace SokoBan
{
    public class EmptyTile : Tile
    {
        public override Tile TileUp { get; set; }
        public override Tile TileDown { get; set; }
        public override Tile TileLeft { get; set; }
        public override Tile TileRight { get; set; }

        public override char Print()
        {
            return ' ';
        }
        public override void MoveOver()
        {
        }
    }
}