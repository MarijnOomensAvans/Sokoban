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

        internal bool checkIfPlayerCanMove(int direction)
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

            if (destination != null && !destination.hasCrate() && destination.Print() != '#')
            {
                return true;
            }

            if (destination.hasCrate())
            {
                if (destination.Crate.CanMove(direction))
                {
                    
                }
                
            }

            return false;
        }

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


            if (destination != null && !destination.hasCrate())
            {
                destination.setPlayer(Player);
                deletePlayer();
                return destination;
            }

            return null;
        }

        private void setPlayer(Player player)
        {
            Player = player;
        }

        private void placeCrate(Crate crate)
        {
            Crate = crate;
        }

        public Player Player { get; set; }
        public Crate Crate { get; set; }


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