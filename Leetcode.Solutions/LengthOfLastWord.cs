namespace Leetcode.Solutions;

public static class LengthOfLastWord
{
    public static int Solution(string s)
    {
        int lengthWord = 0;
        int sIndex = s.Length - 1;
        
        while (string.IsNullOrWhiteSpace(s[sIndex].ToString()) && sIndex >= 0)
        {
            sIndex--;
        }

        for (; sIndex >= 0; lengthWord++, sIndex--)
        {
            if (string.IsNullOrWhiteSpace(s[sIndex].ToString()))
            {
                break;
            }
        }

        return lengthWord;
    }
}