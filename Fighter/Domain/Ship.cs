using Fighter.Technical;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Domain
{
    public abstract class Ship : Asset, IMovable, IRotationable
    {

        public int Life { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; }

        public float Rotation { get; set; }


        public Ship(Game game, string path, int width, int height, int x, int y, int life, int armor, int speed) : base(game, path, width, height, x, y)
        {
            this.Life = life;
            this.Armor = armor;
            this.Speed = speed;
            this.Rotation = 0;
        }

        public void Move(Asset asset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    this.Y -= this.Speed;
                    break;
                case Direction.Right:
                    this.X += Speed;
                    break;
                case Direction.Down:
                    this.Y += Speed;
                    break;
                case Direction.Left:
                    this.X -= Speed;
                    break;
            }
        }

        public void Rotate(Asset asset, Sens sens)
        {
            switch (sens)
            {
                case Sens.Left:
                    this.Rotation -= 0.01f;
                    break;
                case Sens.Right:
                    this.Rotation += 0.01f;
                    break;
            }
        }
    }
}
