using NUnit.Framework;
using Tasks.Easy.MergeTwoSortedLists;

namespace Tests.EasyTests.MergeTwoSortedListsTests
{
    [TestFixture]
    public class MergeTwoSortedListsTests
    {

        [Test]
        public void Method1()
        {
            ListNode ln1 = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 4,
                        next = null
                    }
                }
            };

            ListNode ln2 = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 3,
                    next = new ListNode
                    {
                        val = 4,
                        next = null
                    }
                }
            };

            var result = MergeTwoSortedLists.MergeTwoLists(ln1, ln2);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.next.val);
        }

        [Test]
        public void Method2()
        {
            ListNode ln1 = new ListNode();

            ListNode ln2 = new ListNode
            {
                val = 0,
                next = null
            };

            var result = MergeTwoSortedLists.MergeTwoLists(ln1, ln2);

            Assert.AreEqual(0, result.val);
        }
    }
}
