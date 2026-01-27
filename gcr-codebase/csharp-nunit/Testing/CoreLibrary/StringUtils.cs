using System;

public class StringUtils
{
    public string Reverse(string text)
    {
        char[] arr = text.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string text)
    {
        string reversed = Reverse(text);
        return text == reversed;
    }

    public string ToUpperCase(string text)
    {
        return text.ToUpper();
    }
}
