using System;

namespace FruitBurstBackend
{
    public class ScoreAndLevel
    {
        public int Score { get; private set;}
        public int Level {get; private set;}

        public ScoreAndLevel()
        {
            Score = 0;
            Level = 0;
        }

        //Increment Score by the number of points we get from the fruit
        public void UpdateScore(IFruit fruit)
        {
            Score += fruit.Points;
        }

        //Increment the level by 1
        public void IncrementLevel()
        {
            Level++;
        }
    }
}