using NUnit.Framework;
using Tasks.Easy.RomanToInteger;

namespace Tests.Easy.RomanToIntegerTests
{
    public class RomanToIntegerTests
    {
        [Test]
        [TestCase("III", ExpectedResult = 3)]
        [TestCase("IV", ExpectedResult = 4)]
        [TestCase("IX", ExpectedResult = 9)]
        [TestCase("LVIII", ExpectedResult = 58)]
        [TestCase("MCMXCIV", ExpectedResult = 1994)]
        public int RomanToInt(string roman)
        {
            return RomanToInteger.RomanToInt(roman);
        }
    }
}
