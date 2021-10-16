using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class FruitTest
    {
        [TestMethod]
        public void TestInitializationPoints()
        {
            IFruit fruit = new Fruit();
            int minValue = 1;
            int maxValue = 5;
            bool result = false;
            if (fruit.Points >= minValue && fruit.Points <= maxValue)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
