using NUnit.Framework;
using Tasks.Hard.ReducingDishes;

namespace Tests.HardTests.ReducingDishesTests
{
    [TestFixture]
    internal class ReducingDishesTests
    {
        [Test]
        public void Method1()
        {
            Assert.AreEqual(14, ReducingDishes.MaxSatisfaction(new int[] { -1, -8, 0, 5, -9 }));
        }

        [Test]
        public void Method2()
        {
            Assert.AreEqual(20, ReducingDishes.MaxSatisfaction(new int[] { 4, 3, 2 }));
        }

        [Test]
        public void Method3()
        {
            Assert.AreEqual(0, ReducingDishes.MaxSatisfaction(new int[] { -1, -4, -5 }));
        }

        [Test]
        public void Method4()
        {
            Assert.AreEqual(35, ReducingDishes.MaxSatisfaction(new int[] { -2, 5, -1, 0, 3, -3 }));
        }
    }
}
