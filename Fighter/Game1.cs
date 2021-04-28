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

        private AssetHandler _assetHandler;


        private int v1 = 0;
        private int v2 = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            ///Singleton
            _assetHandler = AssetHandler.GetInstance();

            ///Monogame Loading Content
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            ///Game Assets
            _background = new Background(this, "Images/back", 800, 480);
            _heroShip = new HeroShip(this, "Images/white_ship", 50, 50, 400, 400, 100, 100, 8);   //créer une fabrique
            _enemyShip = new EnemyShip(this, "Images/enemy_ship", 50, 50, 400, 50, 50, 0, 5);
        }

        protected override void Update(GameTime gameTime)
        {
            ///Move Handling
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad6))
            {
                _assetHandler.Move(_heroShip, Direction.Right);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad4))
            {
                _assetHandler.Move(_heroShip, Direction.Left);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad8))
            {
                _assetHandler.Move(_heroShip, Direction.Up);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad2))
            {
                _assetHandler.Move(_heroShip, Direction.Down);
            }

            ///Rotate Handling
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad9))
            {
                _assetHandler.Rotate(_heroShip, Sens.Right);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad7))
            {
                _assetHandler.Rotate(_heroShip, Sens.Left);
            }

            ///Test Rotation Debug
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                v1 += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                v2 += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                v1 -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                v2 -= 1;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_background.GetImage(), _background.GetRectangle(), Color.White);
            _spriteBatch.Draw(_heroShip.GetImage(), _heroShip.GetRectangle(), null, Color.White, _heroShip.Rotation, new Vector2(10, 10), SpriteEffects.None, 1);
            _spriteBatch.Draw(_enemyShip.GetImage(), _enemyShip.GetRectangle(), Color.White);
           
            SpriteFont font = Content.Load<SpriteFont>("Fonts/Score");
            _spriteBatch.DrawString(font, $"Rotation : {_heroShip.Rotation}", new Vector2(20, 10), Color.Yellow);
            _spriteBatch.DrawString(font, $"new Vector2({v1},{v2})", new Vector2(20, 40), Color.Yellow);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
