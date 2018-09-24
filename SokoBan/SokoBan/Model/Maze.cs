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
        public List<Crate> CrateList { get; set; }
        public List<Tile> TileList { get; set; }
        public Tile OriginPoint { get; set; }

        public Maze(int level)
        {
            string txtFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString();
            String[] MazeStringArray =
                System.IO.File.ReadAllLines(@"" + txtFile + "/Sokoban/Doolhoffen/doolhof" + level + ".txt");

            bool FirstLine = true;
            bool FirstChar = true;

            foreach (string MazeLine in MazeStringArray)
            {
                FirstChar = true;
                foreach (char c in MazeLine)
                {
                    Tile t;
                    switch (c)
                    { 
                        case '.':
                            t = new FloorTile();
                            break;
                        case 'o':
                            t = new FloorTile();
                            t.Crate = new Crate();
                            break;
                        case '#':
                            t = new Wall();
                            break;
                        case 'x': 
                            t = new EndTile();
                            break;
                        case '@': 
                            t = new FloorTile();
                            Player = new Player(t);
                            t.Player = Player;
                            break;
                        default: 
                            t = new EmptyTile();
                            break;
                    }

                    if (FirstLine)
                    {
                        if (FirstChar)
                        {

                        }
                    }
                }
            }
        }
    }
}