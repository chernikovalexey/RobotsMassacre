﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Tile;
using Gfx;

namespace Entity.Details
{
    public class GrassShore : Shore
    {
        public override int Type { get { return TileType.D_GRASS_SHORE; } }

        public GrassShore(float x, float y, Directions Dir) : base(x, y, Dir) { }

        public override void Render(GBitmap screen)
        {
            screen.Blit(Art.Rotate(Art.GRAPHICS[4 + ShoreState, 4], (int)Direction * 90), iX, iY);
        }
    }
}