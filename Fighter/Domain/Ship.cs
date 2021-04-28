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
        private const float ShipDefaultRotationSpeed = 0.05f;

        public int Life { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; }

        public Rotation Rotation { get; set; }



        public Ship(Game game, string path, int width, int height, int x, int y, int life, int armor, int speed) : base(game, path, width, height, x, y)
        {
            this.Life = life;
            this.Armor = armor;
            this.Speed = speed;
            this.Rotation = new Rotation(Sens.None, ShipDefaultRotationSpeed);
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

        public void Rotate(Asset asset, Rotation rotation)
        {
            switch (rotation.Sens)
            {
                case Sens.Left:
                    this.Rotation.Angle -= this.Rotation.Speed; ;
                    break;
                case Sens.Right:
                    this.Rotation.Angle += this.Rotation.Speed;
                    break;
            }
        }
    }


}
