using NUnit.Framework;
using Tasks.Easy.PalindromeNumber;

namespace Tests.Easy.LongestCommonPrefixTests
{
    public class LongestCommonPrefixTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LongestCommonPrefix_fl()
        {
            var expected = "fl";
            var strs = new string[] { "flower", "flow", "flight" };
            var actual = LongestCommonPrefix.Calculate(strs);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongestCommonPrefix_Empty()
        {
            var expected = "";
            var strs = new string[] { "dog", "racecar", "car" };
            var actual = LongestCommonPrefix.Calculate(strs);
            Assert.AreEqual(expected, actual);
        }
    }
}