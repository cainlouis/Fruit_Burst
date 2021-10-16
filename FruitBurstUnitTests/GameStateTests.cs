using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class GameStateTests
    {
        [TestMethod]
        public void TestInitializationScoreAndLevel_IsNotNull()
        {
            GameState gs = new GameState(5,5);
            Assert.IsNotNull(gs.ScoreAndLevelCounter);
        }

        [TestMethod]
        public void TestInitializationScoreAndGrid_IsNotNull()
        {
            GameState gs = new GameState(5,5);
            Assert.IsNotNull(gs.Grid);
        }

        [TestMethod]
        public void TestMakeFruitAppear()
        {
            GameState gs = new GameState(5,5);
            bool result = false;
            gs.MakeFruitsAppear();
            for (int i = 0; i < gs.Grid.Height; i++)
            {
                for (int j = 0; j < gs.Grid.Width; j++) 
                {
                    if (gs.Grid[i,j].IsVisible == true)
                    {
                        result = true;
                    }
                }
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSetInvisibleAt()
        {
            GameState gs = new GameState(5,5);
            gs.Grid[1,1].IsVisible = true;
            Assert.IsTrue(gs.Grid[1,1].IsVisible);

            gs.SetInvisibleAt(1,1);
            Assert.IsFalse(gs.Grid[1,1].IsVisible);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSetInvisibleAt_OutOfRangePosition_ThrowException()
        {
            GameState gs = new GameState(5,5);
            gs.Grid[6,6].IsVisible = true;
        }

        [TestMethod]
        public void TestUpdateScore() 
        {
            GameState gs = new GameState(5,5);
            gs.UpdateScore(new Fruit());
            bool result = false;
            if (gs.ScoreAndLevelCounter.Score >= 1)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIncrementLevel() 
        {
            GameState gs = new GameState(5,5);
            gs.IncrementLevel();
            bool result = false;
            if (gs.ScoreAndLevelCounter.Level == 1)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}