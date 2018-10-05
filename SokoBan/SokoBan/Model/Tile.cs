﻿using System;
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
        public abstract void MoveOver();

        internal bool checkIfPMovableCanMove(int direction)
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

            if (destination != null && !destination.HasMovable() && destination.Print() != '#')
            {
                return true;
            }

            if (destination.HasMovable())
            {
                if (destination.Movable.Type == 1 && (Movable.Type == 0 || Movable.Type == 2))
                {
                    if (destination.Movable.CanMove(direction))
                    {
                        destination.Movable.Move(direction);
                        return true;
                    }
                    
                }
                if (destination.Movable.Type == 2 && Movable.Type == 0)
                {
                    destination.Movable.State = 1;
                    return false;
                }
            }

            return false;
        }

        internal Tile moveMovable(int direction)
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


            if (destination != null && !destination.HasMovable())
            {
                if (destination.Print()== 'x' && Movable.Type == 1)
                {
                    Maze.CratesOnEndTiles++;
                }

                if (destination.Print() == '~')
                {
                    destination.MoveOver();
                }

                if (destination.Print() == ' ')
                {
                    if (Movable.Type == 1)
                    {
                        deleteMovable();
                        return null;
                    }
                }
                destination.SetMovable(Movable);
                deleteMovable();
                return destination;
            }

            return null;
        }

        private void SetMovable(Movable movabable)
        {
            Movable = movabable;
        }

        public Movable Movable { get; set; }


        public bool HasMovable()
        {
            if (Movable != null)
            {
                return true;
            }

            return false;
        }

        public int GetMovableType()
        {
            return Movable.Type;
        }

        public void deleteMovable()
        {
            Movable = null;
        }

        public abstract char Print();

    }
}