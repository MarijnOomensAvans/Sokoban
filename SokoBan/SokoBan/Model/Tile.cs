using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public abstract class Tile
    {
        public abstract Tile TileUp { get; set; }
        public abstract Tile TileDown { get; set; }
        public abstract Tile TileLeft { get; set; }
        public abstract Tile TileRight { get; set; }
        public Player Player { get; set; }
        public Crate Crate { get; set; }

        public Tile()
        {
            TileUp = null;
            TileDown = null;
            TileLeft = null;
            TileRight = null;
        }

        public bool isOpen()
        {
            if ((Player == null) && (Crate == null) && ((this.GetType() == typeof(FloorTile)) || (this.GetType() ==  typeof(Wall))))
            {
                return true;
            }

            return false;
        }

        public bool hasPlayer()
        {
            if (Player != null)
            {
                return true;
            }

            return false;
        }

        public void deletePlayer()
        {
            Player = null;
        }

        public bool hasCrate()
        {
            if (Crate != null)
            {
                return true;
            }

            return false;
        }

        public void deleteCrate()
        {
            Crate = null;
        }

    }
}