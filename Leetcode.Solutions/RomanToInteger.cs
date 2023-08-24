namespace Leetcode.Solutions;
/*
    For example, 2 is written as II in Roman numeral, just two ones added together. 
    12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right. 
    However, the numeral for four is not IIII. Instead, the number four is written as IV. 
    Because the one is before the five we subtract it making four. The same principle applies to the number nine, 
    which is written as IX. There are six instances where subtraction is used:
        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.

    Given a roman numeral, convert it to an integer.
*/

public static class RomanToInteger
{
    public static int Solution(string s)
    {
        int res = 0;

        for (int sIndex = 0; sIndex < s.Length; ++sIndex)
        {
            switch (s[sIndex])
            {
                case 'I':
                    if (sIndex + 1 < s.Length && (s[sIndex + 1] == 'V' || s[sIndex + 1] == 'X'))
                    {
                        res -= 1;
                    }
                    else
                    {
                        res += 1;
                    }
                    break;
                case 'V':
                    res += 5;
                    break;
                case 'X':
                    if (sIndex + 1 < s.Length && (s[sIndex + 1] == 'L' || s[sIndex + 1] == 'C'))
                    {
                        res -= 10;
                    }
                    else
                    {
                        res += 10;
                    }
                    break;
                case 'L':
                    res += 50;
                    break;
                case 'C':
                    if (sIndex + 1 < s.Length && (s[sIndex + 1] == 'D' || s[sIndex + 1] == 'M'))
                    {
                        res -= 100;
                    }
                    else
                    {
                        res += 100;
                    }
                    break;
                case 'D':
                    res += 500;
                    break;
                case 'M':
                    res += 1000;
                    break;
            }
        }
        
        return res;
    }
}