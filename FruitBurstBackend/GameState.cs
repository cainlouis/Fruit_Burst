using System;

namespace FruitBurstBackend
{
    public class GameState
    {
        public IFruit[,] Grid{get;}
        public ScoreAndLevel ScoreAndLevelCounter{get;}
        private Random random;

        public GameState(int length, int width)
        {
            Grid = new Fruit[length, width];
            ScoreAndLevelCounter = new ScoreAndLevel();
            random = new Random();
        }

        public void MakeFruitsAppear()
        {
           int randI = random.Next(Grid.GetLength(0));
           int randJ = random.Next(Grid.GetLength(1));
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