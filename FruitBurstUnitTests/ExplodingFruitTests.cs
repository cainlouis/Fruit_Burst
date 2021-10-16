using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class ExplodingFruitTests
    {
        [TestMethod]
        public void TestPoints_IsNegative()
        {
            IFruit fruit = new Fruit();
            ExplodingFruit expFruit = new ExplodingFruit(fruit);
            bool result = false;
            if (expFruit.Points < 0) {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsVisible_IsFalse() {
            IFruit fruit = new Fruit();
            ExplodingFruit expFruit = new ExplodingFruit(fruit);
            Assert.IsFalse(expFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeVisible_IsVisibleIsTrue()
        {
            IFruit fruit = new Fruit();
            ExplodingFruit expFruit = new ExplodingFruit(fruit);
            expFruit.MakeVisible();
            Assert.IsTrue(expFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeInvisible_IsVisibleIsFalse()
        {
            IFruit fruit = new Fruit();
            ExplodingFruit expFruit = new ExplodingFruit(fruit);
            expFruit.MakeVisible();
            expFruit.MakeInvisible();
            Assert.IsFalse(expFruit.IsVisible);
        }
    }
}
