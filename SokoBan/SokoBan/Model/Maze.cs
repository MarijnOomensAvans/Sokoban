﻿using System;
using System.Collections.Generic;
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
    }
}