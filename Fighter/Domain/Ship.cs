using Fighter.Technical;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Domain
{
    public abstract class Ship : Asset
    {

        public int Life { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; }


        public Ship(Game game, string path, int x, int y) : base(game, path, x, y)
        {

        }
        public Ship(Game game, string path, int x, int y, int width, int height) : base(game, path, x, y, width, height)
        {

        }

        public Ship(Game game, string path, int x, int y, int life, int armor, int speed) : base(game, path, x, y)
        {
            this.Life = life;
            this.Armor = armor;
            this.Speed = speed;
        }


    }
}
