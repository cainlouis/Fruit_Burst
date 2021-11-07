using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class FruitTest
    {
        [TestMethod]
        public void TestInitializationPoints_IsWithinRange()
        {
            IFruit fruit = new Fruit();
            bool result = false;
            if (fruit.Points >= 1 && fruit.Points <= 5)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestInitializationIsVisible_IsFalse()
        {
            IFruit fruit = new Fruit();
            bool result = fruit.IsVisible;
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMakeVisible_IsVisibleIsTrue()
        {
            IFruit fruit = new Fruit();
            fruit.MakeVisible();
            Assert.IsTrue(fruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeInvisible_IsVisibleIsFalse()
        {
            IFruit fruit = new Fruit();
            fruit.MakeVisible();
            fruit.MakeInvisible();
            Assert.IsFalse(fruit.IsVisible);
        }
    }
}
