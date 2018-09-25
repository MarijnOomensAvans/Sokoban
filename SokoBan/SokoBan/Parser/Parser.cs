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
        private string[] MazeStringArray;

        public Maze parseMaze(int level)
        {
            {
                map = new GridList();
                Maze = new Maze();
                string txtFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString();
                MazeStringArray =
                    System.IO.File.ReadAllLines(@"" + txtFile + "/Sokoban/Doolhoffen/doolhof" + level + ".txt");

                bool FirstLine = true;
                bool FirstChar = true;
                bool FirstLineAndChar = true;

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
                                Crate crate = new Crate(t);
                                t.Crate = crate;
                                break;
                            case '#':
                                t = new Wall();
                                break;
                            case 'x':
                                t = new EndTile();
                                Maze.EndTileList.Add((EndTile)t);
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

                        if (FirstLine)
                        {
                            if (FirstLineAndChar)
                            {
                                Maze.OriginPoint = t;
                                map.FirstTile = t;
                                map.CurrentTile = t;
                                FirstLineAndChar = false;
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
                                while (cTile.TileDown != null)
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
                                t.TileUp = map.CurrentTile.TileUp.TileRight;
                                t.TileUp.TileDown = t;
                                map.CurrentTile = map.CurrentTile.TileRight;
                            }
                        }
                    }

                    FirstLine = false;
                }
            }
            currentMazeHeight();
            currentMazeWidth();

            return Maze;
        }

        public void currentMazeHeight()
        {
            Maze.Height = MazeStringArray.Length;
        }

        public void currentMazeWidth()
        {
            Maze.Width = MazeStringArray[0].Length;
        }

        public class GridList
        {
            public Tile FirstTile;
            public Tile CurrentTile;
        }
    }
}
