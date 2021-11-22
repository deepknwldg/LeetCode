using NUnit.Framework;
using Tasks._9._Palindrome_Number;

namespace Tests.PalindromeNumberTests
{
    public class Tests
    {
        const int MAX_INT = int.MaxValue;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, true)]
        [TestCase(121, true)]
        [TestCase(1123211, true)]
        [TestCase(-121, false)]
        [TestCase(12, false)]
        [TestCase(MAX_INT, false)]
        public void IsPolindrome(int x, bool expected)
        {
            var actual = PalindromeNumber.IsPalindrome(x);
            Assert.AreEqual(expected, actual);
        }
    }
}