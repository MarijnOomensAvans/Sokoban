using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Sleeper : Movable
    {
        public Sleeper()
        {
            Type = 2;
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