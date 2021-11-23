namespace Tasks.RomanToInteger
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var alphabet = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var length = s.Length - 1;
            var total = alphabet[s[length]];

            for (int i = length - 1; i >= 0; i--)
            {
                var current = alphabet[s[i]];
                total += (alphabet[s[i + 1]] > current ? -1 : 1) * current;
            }

            return total;
        }
    }
}
