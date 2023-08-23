namespace Leetcode.Solutions;

/*
    Given an array nums of size n, return the majority element.

    The majority element is the element that appears more than ⌊n / 2⌋ times.
    You may assume that the majority element always exists in the array.
 */

public static class MajorityElement
{
    public static int Solution(int[] nums)
    {
        Dictionary<int, int> numsCount = new Dictionary<int, int>();

        for (int numsIndex = 0; numsIndex < nums.Length; ++numsIndex)
        {
            if (numsCount.ContainsKey(nums[numsIndex]))
            {
                numsCount[nums[numsIndex]]++;
            }
            else
            {
                numsCount.Add(nums[numsIndex], 1);
            }
        }

        int maxNum = nums[0];
        foreach (int key in numsCount.Keys)
        {
            if (numsCount[maxNum] < numsCount[key])
            {
                maxNum = key;
            }
        }
        
        return maxNum;
    }
}