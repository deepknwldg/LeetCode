namespace Tasks.PalindromeNumber
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedValue = 0;

            while (x > revertedValue)
            {
                revertedValue = revertedValue * 10 + x % 10;
                x /= 10;
            }

            return x == revertedValue || x == revertedValue / 10;
        }
    }
}
