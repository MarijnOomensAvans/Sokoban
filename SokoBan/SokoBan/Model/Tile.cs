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

        internal Tile movePlayerTile(int direction)
        {
            Tile destination = null;
            switch (direction)
            {
                case 1:
                    destination = TileUp;
                    break;
                case 2:
                    destination = TileDown;
                    break;
                case 3:
                    destination = TileLeft;
                    break;
                case 4:
                    destination = TileRight;
                    break;
            }

            if (destination.hasCrate())
            {
                destination.moveCrate(direction);
            }

            if (destination != null && destination.isOpen() && !destination.hasCrate())
            {
                destination.setPlayer(Player);
                deletePlayer();
                return destination;
            }
            else
            {
                return null;
            }
            
        }

        private void setPlayer(Player player)
        {
            Player = player;
        }

        private void moveCrate(int direction)
        {
            Tile destination = null;
            switch (direction)
            {
                case 1:
                    destination = TileUp;
                    break;
                case 2:
                    destination = TileDown;
                    break;
                case 3:
                    destination = TileLeft;
                    break;
                case 4:
                    destination = TileRight;
                    break;
            }

            if (destination != null && destination.isOpen())
            {
                destination.placeCrate(Crate);
            }

        }

        private void placeCrate(Crate crate)
        {
            Crate = crate;
            Crate.putCrateOn(this);
        }

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

        public abstract char Print();

    }
}