namespace Leetcode.Solutions;

public static class RemoveDuplicatesFromSortedArrayII
{
    public static int Solution(int[] nums)
    {
        int numsSize = 2;
        int numSize = 1;
        for (int numsIndex = 2; numsIndex < nums.Length; ++numsIndex)
        {
            if (nums[numsIndex - 2] != nums[numsIndex] && numSize < 2)
            {
                nums[numsSize] = nums[numsIndex];
                numsSize++;
                numSize = 0;
            }
        }
        
        return numsSize;
    }
}