using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Crate
    {
        private Tile _onTile;

        public void putCrateOn(Tile t)
        {
            _onTile = t;
        }

        public bool isOnEndTile() // TODO wordt niet gebruikt voor einde level
        {
            if (_onTile.GetType() == typeof(EndTile))
            {
                return true;
            }
            return false;
        }

    }
}