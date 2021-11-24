using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Easy.ReverseBits;

namespace Tests.EasyTests.ReverseBitsTests
{
    internal class ReverseBitsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(4294967293, 3221225471)]
        [TestCase(43261596, 964176192)]
        public void ReverseBitsMethod(uint x, uint expected)
        {
            uint @in = (uint)x;
            var actual = ReverseBits.ReverseBitsMethod(@in);
            Assert.AreEqual(expected, actual);
        }
    }
}
