using Fighter.Technical;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Domain
{
    public class Background : Asset
    {
        public Background(Game game, string path, int width, int height) : base(game, path, width, height)
        {
            this.X = 0;
            this.Y = 0;
        }
    }
}
