using NUnit.Framework;
using Tasks.Easy.RemoveElement;

namespace Tests.EasyTests.RemoveElementTests
{
    [TestFixture]
    internal class RemoveElementsTests
    {

        [Test]
        public void Method1()
        {
            Assert.AreEqual(2, RemoveElement.RemoveElementMethod(new int[] { 3, 2, 2, 3 }, 3));
        }

        [Test]
        public void Method2()
        {
            Assert.AreEqual(5, RemoveElement.RemoveElementMethod(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
        }
    }
}
