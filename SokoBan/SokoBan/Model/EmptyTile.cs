using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class EmptyTile : Tile
    {
        public override Tile TileUp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Tile TileDown { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Tile TileLeft { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Tile TileRight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}