using Fighter.Domain;
using Fighter.Technical;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Fighter
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Asset _background;
        private HeroShip _heroShip;
        private EnemyShip _enemyShip;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _background = new Background(this, "Images/back", 800, 480);
            _heroShip = new HeroShip(this, "Images/white_ship", 50, 50, 400, 400, 100, 100, 8);   //créer une fabrique
            _enemyShip = new EnemyShip(this, "Images/enemy_ship", 50, 50, 400, 50, 50, 0, 5);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                _heroShip.X += _heroShip.Speed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                _heroShip.X -= _heroShip.Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                _heroShip.Y -= _heroShip.Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                _heroShip.Y += _heroShip.Speed;
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_background.GetImage(), _background.GetRectangle(), Color.White);
            _spriteBatch.Draw(_heroShip.GetImage(), _heroShip.GetRectangle(), Color.White);
            _spriteBatch.Draw(_enemyShip.GetImage(), _enemyShip.GetRectangle(), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
