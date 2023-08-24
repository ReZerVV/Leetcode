namespace Leetcode.Solutions;

/*
    Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
*/

public static class RotateArray
{
    public static void Solution(int[] nums, int k)
    {
        for (int stepCounter = 0; stepCounter < k; stepCounter++)
        {
            int num = nums[nums.Length - 1];
            Array.Copy(nums, 0, nums, 1, nums.Length - 1);
            nums[0] = num;
        }
    }
}