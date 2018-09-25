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
        public Tile OriginPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int AmountOfEndTiles { get; set; }
        public int CratesOnEndTiles { get; set; } //TODO moet nog worden opgehoogd

        public void movePlayer(int direction)
        {
            Player.MoveTo(direction);
        }

        public bool CheckGameWon()
        {
            return (CratesOnEndTiles == AmountOfEndTiles);
        }
    }
}