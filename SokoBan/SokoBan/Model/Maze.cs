using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Maze
    {
        public Player Player { get; set; }
        public Sleeper Sleeper { get; set; }
        public Tile OriginPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int AmountOfEndTiles { get; set; }
        public static int CratesOnEndTiles { get; set; }

        public void movePlayer(int direction)
        {
            if (Player.CanMove(direction))
            {
                Player.Move(direction);
                if (Sleeper != null)
                {
                    Sleeper.SleeperAction();
                }
            }
        }

        public bool CheckGameWon()
        {
            return (CratesOnEndTiles == AmountOfEndTiles);
        }
    }
}