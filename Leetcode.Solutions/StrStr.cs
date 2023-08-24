namespace Leetcode.Solutions;

/*
    Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
     or -1 if needle is not part of haystack.
*/

public static class StrStr
{
    public static int Solution(string haystack, string needle)
    {
        for (int haystackIndex = 0; haystackIndex < haystack.Length; haystackIndex++)
        {
            for (int haystackFindIndex = haystackIndex; haystackFindIndex - haystackIndex < needle.Length && haystackFindIndex < haystack.Length; haystackFindIndex++)
            {
                int needleIndex = haystackFindIndex - haystackIndex;
                if (haystack[haystackFindIndex] != needle[needleIndex])
                {
                    break;
                }
                
                if (needleIndex == needle.Length - 1)
                {
                    return haystackIndex;
                }
            }
        }

        return -1;
    }
}