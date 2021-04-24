using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Domain
{
    public class EnemyShip : Ship
    {
        public EnemyShip(Game game, string path, int x, int y) : base(game, path, x, y)
        {
            this.Width = 50;
            this.Height = 50;
        }

        public EnemyShip(Game game, string path, int x, int y, int life, int armor, int speed) : base(game, path, x, y, life, armor, speed)
        {
            this.Width = 50;
            this.Height = 50;
        }
        public EnemyShip(Game game, string path, int x, int y, int width, int height) : base(game, path, x, y, width, height)
        {
            this.Width = 50;
            this.Height = 50;
        }
        public EnemyShip(Game game, string path, int x, int y, int width, int height, int life, int armor, int speed) : base(game, path, x, y, life, armor, speed)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
