using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class TestMagicFruit
    {
        [TestMethod]
        public void TestInitialization_HPEquals20()
        {
            MagicFruit mFruit = new MagicFruit(new Fruit());
            int expected = 20;
            int result = mFruit.HP;
            Assert.AreEqual(expected,  result);
        }

        [TestMethod]
        public void TestInitialization_IsVisibleIsFalse()
        {
            MagicFruit mFruit = new MagicFruit(new Fruit());
            Assert.IsFalse(mFruit.IsVisible);
        }
    }
}