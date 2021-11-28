public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        var parenthesesStack = new Stack<char>();

        foreach (var ch in s)
        {
            if (ch == '(')
                parenthesesStack.Push(')');
            else if (ch == '[')
                parenthesesStack.Push(']');
            else if (ch == '{')
                parenthesesStack.Push('}');
            else if (parenthesesStack.Count == 0 || parenthesesStack.Pop() != ch)
            {
                return false;
            }
        }

        return parenthesesStack.Count == 0;
    }
}