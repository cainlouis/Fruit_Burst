using FruitBurstBackend;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FruitBurst
{
    public class ScoreAndLevelSprite: DrawableGameComponent
    {
        private Game1 game;
        //The object we need for the level and score
        private ScoreAndLevel scoreAndLevel;
        //the font that we use
        private SpriteFont font;
        private SpriteBatch spriteBatch;

        public ScoreAndLevelSprite(Game1 game): base(game)
        {
            this.game = game;
        }
        
        //overloaded constructor initializes the game and scoreAndLevel fields
        public ScoreAndLevelSprite(Game1 game, ScoreAndLevel scoreAndLevel): base(game)
        {
            this.game = game;
            this.scoreAndLevel = scoreAndLevel;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //Loade the SpriteFont
            font = game.Content.Load<SpriteFont>("font");
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            //Draw the spriteFont
            spriteBatch.DrawString(font, "Score: " + this.scoreAndLevel.Score + "\nLevel: " + this.scoreAndLevel.Level,new Vector2(5, 800), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}