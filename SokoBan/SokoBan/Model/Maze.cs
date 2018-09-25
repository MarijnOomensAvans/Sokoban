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
        public List<EndTile> EndTileList { get; set; }
        public Tile OriginPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Maze()
        {
            EndTileList = new List<EndTile>();
        }

        public void movePlayer(int direction)
        {
            Player.MoveTo(direction);
        }

        public bool CheckGameWon()
        {
            int size = 0;
            int complete = 0;
            foreach (EndTile t in EndTileList)
            {
                size++;
                if (t.hasCrate())
                {
                    complete++;
                }
            }

            if (size == complete)
            {
                return true;
            }

            return false;
        }
    }
}