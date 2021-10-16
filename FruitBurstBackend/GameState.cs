using System;

namespace FruitBurstBackend
{
    public class GameState
    {
        public FruitGrid Grid{get;}
        public ScoreAndLevel ScoreAndLevelCounter{get;}
        private Random random;

        public GameState(int height, int width)
        {
            Grid = new FruitGrid(height, width);
            ScoreAndLevelCounter = new ScoreAndLevel();
            random = new Random();
        }

        public void MakeFruitsAppear()
        {
           int randI = random.Next(Grid.Height);
           int randJ = random.Next(Grid.Width);
           Grid[randI,randJ].MakeVisible();
        }

        public void SetInvisibleAt(int i, int j)
        {
            Grid[i,j].MakeInvisible();
        }

        public void UpdateScore(IFruit fruit)
        {
            ScoreAndLevelCounter.UpdateScore(fruit);
        }

        public void IncrementLevel()
        {
            ScoreAndLevelCounter.IncrementLevel();
        }
    }
}