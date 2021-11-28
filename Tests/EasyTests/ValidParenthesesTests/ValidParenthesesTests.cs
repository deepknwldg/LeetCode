using NUnit.Framework;
using Tasks.Easy.RomanToInteger;

namespace Tests.Easy.ValidParenthesesTests
{
    public class ValidParenthesesTetss
    {
        [Test]
        [TestCase("()", ExpectedResult = true)]
        [TestCase("()[]{}", ExpectedResult = true)]
        [TestCase("(]", ExpectedResult = false)]
        [TestCase("([)]", ExpectedResult = false)]
        [TestCase("{[]}", ExpectedResult = true)]
        public bool IsValid(string parentheses)
        {
            return ValidParentheses.IsValid(parentheses);
        }
    }
}
