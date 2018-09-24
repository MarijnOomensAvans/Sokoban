using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Parser
    {
        private Maze Maze;
        public GridList map;

        public Maze parseMaze(int level)
        {
            {
                map = new GridList();
                Maze = new Maze();
                Tile CurrentTile;
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
                                Maze.CrateList.Add(t.Crate);
                                break;
                            case '#':
                                t = new Wall();
                                break;
                            case 'x':
                                t = new EndTile();
                                break;
                            case '@':
                                t = new FloorTile();
                                Maze.Player = new Player(t);
                                t.Player = Maze.Player;
                                break;
                            default:
                                t = new EmptyTile();
                                break;
                        }
                        Maze.TileList.Add(t);

                        if (FirstLine)
                        {
                            if (FirstChar)
                            {
                                Maze.OriginPoint = t;
                                map.FirstTile = t;
                                CurrentTile = t;
                                FirstChar = false;
                            }
                            else
                            {
                                map.CurrentTile.TileRight = t;
                                t.TileLeft = map.CurrentTile;
                                map.CurrentTile = map.CurrentTile.TileRight;
                            }
                        }
                        else
                        {
                            if (FirstChar)
                            {
                                Tile cTile = map.FirstTile;
                                if (cTile.TileDown != null)
                                {
                                    cTile = cTile.TileDown;
                                }

                                cTile.TileDown = t;
                                t.TileUp = cTile;
                                map.CurrentTile = cTile.TileDown;
                                FirstChar = false;
                            }
                            else
                            {
                                map.CurrentTile.TileRight = t;
                                t.TileLeft = map.CurrentTile;
                                t.TileUp.TileDown = t;
                                map.CurrentTile = map.CurrentTile.TileRight;
                            }
                        }
                    }

                    FirstLine = false;
                }
            }
            return Maze;
        }
        public class GridList
        {
            public Tile FirstTile;
            public Tile CurrentTile;
        }
    }
}
