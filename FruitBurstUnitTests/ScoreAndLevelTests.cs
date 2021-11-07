using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class ScoreAndLevelTest
    {
        [TestMethod]
        public void TestInitializationScore_Equals0()
        {
            ScoreAndLevel sL = new ScoreAndLevel();
            int result = sL.Score;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestInitializationLevel_Equals0()
        {
            ScoreAndLevel sL = new ScoreAndLevel();
            int result = sL.Level;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestUpdateScore()
        {
            ScoreAndLevel sL = new ScoreAndLevel();
            sL.UpdateScore(new Fruit());
            bool result = false;
            if (sL.Score >= 1) {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIncrementLevel()
        {
            ScoreAndLevel sL = new ScoreAndLevel();
            sL.IncrementLevel();
            bool result = false;
            if (sL.Level >= 1) {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}