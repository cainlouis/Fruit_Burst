using FruitBurstBackend;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FruitBurst
{
    public class FruitGridSprite: DrawableGameComponent 
    {
        private Texture2D fruitTexture;
        private FruitGrid grid;
        private SpriteBatch spriteBatch;
        private Game1 game;
        private const int px = 100;

        //Initializes the Game1 object
        public FruitGridSprite(Game1 game) : base(game)
        {
            this.game = game;
        }

        //OverLoad the constructor
        public FruitGridSprite(Game1 game, FruitGrid grid): base(game)
        {  
            this.grid = grid;
            this.game = game;
        }

        public override void Initialize()
        {  
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //load the texture
            fruitTexture = game.Content.Load<Texture2D>("kiwi");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {  
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            //go through the aray and draw a visible fruit
            for (int i = 0; i < grid.Height; i++){
                for (int j = 0; j < grid.Width; j++) {
                    if (grid.GetVisibility(i,j)) {
                       spriteBatch.Draw(fruitTexture, new Rectangle(j * px, i * px, px, px), Color.White); 
                    }
                }
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}