using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Domain
{
    public class HeroShip : Ship
    {

        public HeroShip(Game game, string path, int width, int height, int x, int y, int life, int armor, int speed) : base(game, path, width, height, x, y, life, armor, speed)
        {

        }
    }
}
