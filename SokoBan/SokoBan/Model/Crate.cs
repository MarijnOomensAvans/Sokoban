using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Crate : Movable
    {
        public Crate(Tile t)
        {
            onTile = t;
        }

        public override bool CanMove(int direction)
        {
            throw new NotImplementedException();
        }

        public override void Move(int direction)
        {
            throw new NotImplementedException();
        }

    }
}