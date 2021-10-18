using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FruitBurstBackend;

namespace FruitBurst
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        //2 of the sprites
        private FruitGridSprite fSprite;
        private ScoreAndLevelSprite sSprite;

        private GameState gameState;
        private MouseState current;
        private MouseState previous;

        //counter that we use to make the fruit visible
        private int counter;
        //the timer to keep track of the rate at which the fruits appear
        private int maxThresold;
        //this is used to keep track at which rate the user gain level
        private int experience;
        //This is the level at which the stops
        private int maxLevel;
        //this is the int we use to know that they're is too much fruit visible so the game stops
        private int visibleCount;
        private const int px = 100;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            //Initialise the mouseState objects
            current = Mouse.GetState();
            previous = current;

            //initialize the variable used for the game
            counter = 0;
            maxThresold = 60;
            experience = 50;
            maxLevel = 4;
            visibleCount = 0;
        }

        protected override void Initialize()
        {
            this.gameState = new GameState(8, 8);

            //Set the game size
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 1000;
            _graphics.ApplyChanges();

            //creates the sprites
            fSprite = new FruitGridSprite(this, gameState.Grid);
            sSprite = new ScoreAndLevelSprite(this, gameState.ScoreAndLevelCounter);

            //add them to the component
            Components.Add(fSprite);
            Components.Add(sSprite);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            //call counter to make the fruit appear
            Counter();

            /*this keeps track of the score and increase the level
              if the score divided by the exp incremented at each level is bigger than 1*/
            if (this.gameState.ScoreAndLevelCounter.Score / experience > 1)
            {

                experience += 80;
                //increment the level
                this.gameState.IncrementLevel();
                //decrement the maxThresold by 15
                maxThresold -= 10;
            }

            //Call visible to know if we exit the game
            CountVisible();

            //Set the state of the mouseState object
            previous = current;
            current = Mouse.GetState();

            //if the current is clicked and the previous is not
            if (current.LeftButton == ButtonState.Pressed && previous.LeftButton == ButtonState.Released)
            {
                //go through the grid
                for (int i = 0; i < this.gameState.Grid.Height; i++)
                {
                    for (int j = 0; j < this.gameState.Grid.Width; j++)
                    {
                        //create new rectangle to get the position
                        Rectangle rect = new Rectangle(j * px, i * px, px, px);
                        //check if the mouse is clicked at that point in rect and that the visibility is true
                        if (rect.Contains(new Point(current.Position.X, current.Position.Y)) && this.gameState.Grid.GetVisibility(i, j))
                        {
                            //then set invisible at that position
                            this.gameState.SetInvisibleAt(i, j);
                            //and update the score
                            this.gameState.UpdateScore(this.gameState.Grid[i, j]);
                        }
                    }
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }

        /*This method check if the counter has reached the thresold and makes a fruit appear if yes
         if not increment the counter by 1*/
        private void Counter()
        {
            if (counter > maxThresold)
            {
                this.gameState.MakeFruitsAppear();
                counter = 0;
            }
            else
            {
                counter++;
            }
        }

        /*This method set visible count to zero and then look through the grid to count the visible fruits
        then check if we can exit the game*/
        private void CountVisible()
        {
            //Count the number of visible item on the grid
            visibleCount = 0;
            for (int i = 0; i < this.gameState.Grid.Height; i++)
            {
                for (int j = 0; j < this.gameState.Grid.Width; j++)
                {
                    if (this.gameState.Grid[i, j].IsVisible)
                    {
                        visibleCount++;
                    }
                }
            }
            //check if the number of visible is 20 or if we reached the max level and exit if yes
            if (this.gameState.ScoreAndLevelCounter.Level == maxLevel || visibleCount > 20)
            {
                Exit();
            }
        }
    }
}
