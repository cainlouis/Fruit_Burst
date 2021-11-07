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
            int mected = 20;
            int result = mFruit.HP;
            Assert.AreEqual(mected, result);
        }

        [TestMethod]
        public void TestInitialization_IsVisibleIsFalse()
        {
            MagicFruit mFruit = new MagicFruit(new Fruit());
            Assert.IsFalse(mFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeVisible_IsVisibleIsTrue()
        {
            MagicFruit mFruit = new MagicFruit(new Fruit());
            mFruit.MakeVisible();
            Assert.IsTrue(mFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeInvisible_IsVisibleIsTrueWithHPEquals20()
        {
            MagicFruit mFruit = new MagicFruit(new Fruit());
            mFruit.MakeVisible();
            mFruit.MakeInvisible();
            Assert.IsTrue(mFruit.IsVisible);
        }

        [TestMethod]
        public void TestMakeInvisible_IsVisibleIsTrueWithHPEquals0()
        {
            MagicFruit mFruit = new MagicFruit(new Fruit());
            mFruit.MakeVisible();
            mFruit.HP = 0;
            mFruit.MakeInvisible();
            Assert.IsFalse(mFruit.IsVisible);
        }

        [TestMethod]
        public void TestMagicExplodingFruit()
        {
            MagicFruit mf = new MagicFruit(new ExplodingFruit(new Fruit()));
            bool result = false;
            if (mf.Points < 0)
            {
                result = true;
            }
            Assert.IsTrue(result);
            Assert.AreEqual(20, mf.HP);
        }
    }
}