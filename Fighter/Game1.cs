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


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(_background.GetImage(), _background.GetRectangle(), Color.White);
            _spriteBatch.Draw(_heroShip.GetImage(), _heroShip.GetRectangle(), new Rectangle(0, 0, _heroShip.GetImage().Width, _heroShip.GetImage().Height), Color.White, _heroShip.Rotation.Angle, new Vector2(_heroShip.GetImage().Width / 2, _heroShip.GetImage().Height / 2), SpriteEffects.None, 1);
            _spriteBatch.Draw(_enemyShip.GetImage(), _enemyShip.GetRectangle(), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

///TODO
///Déplacement style Android
/////DisplayHandler avec SpriteBatch pour méthode Draw tout comme assetHandler pour Update --> DysplayHandler.Draw(_heroShip), etc...
//////DrawString DEBUG