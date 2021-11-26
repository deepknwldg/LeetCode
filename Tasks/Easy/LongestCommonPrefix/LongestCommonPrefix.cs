using System.Text;

public static class LongestCommonPrefix
{
    public static string Calculate(string[] strs)
    {
        StringBuilder prefix = new StringBuilder();

        if (strs.Length != 0)
        {
            string shortestString = strs[0];
            foreach (var str in strs)
            {
                if (shortestString.Length > str.Length)
                {
                    shortestString = str;
                }
            }

            for (int i = 0; i < shortestString.Length; i++)
            {
                if (strs.Any(str => str[i] != shortestString[i]))
                    return prefix.ToString();

                prefix.Append(shortestString[i]);
            }
        }

        return prefix.ToString();
    }
}