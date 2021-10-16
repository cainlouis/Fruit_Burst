using System;

namespace FruitBurstBackend
{
    public class GameState
    {
        //Property that returns a FruitGrid object
        public FruitGrid Grid{get;}
        
        //Property that returns a ScoreAndLevel object
        public ScoreAndLevel ScoreAndLevelCounter{get;}

        //Field for the Random object
        private Random random;

        //Parameterized constructor that create Grid from the dimension we get as input and ScoreAndLevel 
        public GameState(int height, int width)
        {
            Grid = new FruitGrid(height, width);
            ScoreAndLevelCounter = new ScoreAndLevel();
            random = new Random();
        }

        //set the fruit at [randI,randJ]'s IsVisible to true 
        public void MakeFruitsAppear()
        {
           int randI = random.Next(Grid.Height);
           int randJ = random.Next(Grid.Width);
           Grid[randI,randJ].MakeVisible();
        }

        //Set the fruit at [i,j] to invisible
        public void SetInvisibleAt(int i, int j)
        {
            Grid[i,j].MakeInvisible();
        }

        //Increment the score using the ScoreAndLevel class
        public void UpdateScore(IFruit fruit)
        {
            ScoreAndLevelCounter.UpdateScore(fruit);
        }

        //Increment the level by 1 using the ScoreAndLevel class
        public void IncrementLevel()
        {
            ScoreAndLevelCounter.IncrementLevel();
        }
    }
}