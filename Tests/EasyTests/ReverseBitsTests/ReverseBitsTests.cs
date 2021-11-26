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
        private  uint value = Convert.ToUInt32(43261596);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReverseBitsMethod_1()
        {
            UInt32 expected = 3221225471;
            var actual = ReverseBits.ReverseBitsMethod(4294967293);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseBitsMethod_2()
        {
            UInt32 expected = Convert.ToUInt32(43261596);
            var actual = ReverseBits.ReverseBitsMethod(964176192);
            Assert.AreEqual(expected, actual);
        }
    }
}
