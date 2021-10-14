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

        public void UpdatScore(IFruit fruit)
        {
            Score += fruit.Points;
        }

        public void IncrementLevel()
        {
            Level++;
        }
    }
}