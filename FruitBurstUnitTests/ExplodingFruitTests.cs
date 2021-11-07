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
            ExplodingFruit expFruit = new ExplodingFruit(new Fruit());
            bool result = false;
            if (expFruit.Points < 0) {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsVisible_IsFalse() {
            ExplodingFruit expFruit = new ExplodingFruit(new Fruit());
            Assert.IsFalse(expFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeVisible_IsVisibleIsTrue()
        {
            ExplodingFruit expFruit = new ExplodingFruit(new Fruit());
            expFruit.MakeVisible();
            Assert.IsTrue(expFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeInvisible_IsVisibleIsFalse()
        {
            ExplodingFruit expFruit = new ExplodingFruit(new Fruit());
            expFruit.MakeVisible();
            expFruit.MakeInvisible();
            Assert.IsFalse(expFruit.IsVisible);
        }
    }
}
