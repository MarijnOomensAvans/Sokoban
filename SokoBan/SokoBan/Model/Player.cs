﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Player : Movable
    {

        public Player(Tile t)
        {
            onTile = t;
        }

        public override bool CanMove(int direction)
        {
            throw new NotImplementedException();
        }

        public override void Move(int direction)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(int direction)
        {
            Tile tile = onTile.movePlayerTile(direction);
            onTile = tile;
        }
    }
}