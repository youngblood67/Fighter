using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.Technical
{
    public abstract class Asset
    {
        protected string _path;
        protected Game _game;
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Asset(Game game, string path, int width, int height)
        {
            this._game = game;
            this._path = path;
            this.Width = width;
            this.Height = height;
            this.X = 0;
            this.Y = 0;
        }

        public Asset(Game game, string path, int width, int height, int x, int y)
        {
            this._game = game;
            this._path = path;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public Texture2D GetImage()
        {
            return this._game.Content.Load<Texture2D>(_path);
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle(X, Y, Width, Height);
        }
    }
}
