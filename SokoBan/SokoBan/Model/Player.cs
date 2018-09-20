using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Player
    {
        public Tile onTile { get; set; }

        public Player(Tile t)
        {
            onTile = t;
        }

        public void MoveTo(int direction)
        {

        }
    }
}