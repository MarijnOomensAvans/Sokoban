namespace SokoBan
{
    public class EndTile : Tile
    {
        public override Tile TileUp { get; set; }
        public override Tile TileDown { get; set; }
        public override Tile TileLeft { get; set; }
        public override Tile TileRight { get; set; }

        public override bool MoveTo(Movable movable,int direction)
        {
            if(Movable != null)
            {
                Movable.Move(direction);
                Movable = movable;
                return true;
            }
            /*if(movable.Print() == 'o')
            {
                //TODO: Hier moet wat beters voor worden bedacht
            }*/
            Movable = movable;
            return true;
        }

        public override char Print()
        {
            if (Movable != null)
            {
                return Movable.Print();
            }

            return'x';
        }
    }
}