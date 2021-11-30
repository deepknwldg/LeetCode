using NUnit.Framework;
using Tasks.Easy.RemoveDuplicatesFromSortedArray;

namespace Tests.EasyTests.RemoveDuplicatesFromSortedArrayTests
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTests
    {

        [Test]
        public void Method1()
        {
            Assert.AreEqual(5, RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }
    }
}
