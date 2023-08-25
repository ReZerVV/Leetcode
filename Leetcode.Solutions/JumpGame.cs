namespace Leetcode.Solutions;

/*
    You are given an integer array nums. You are initially positioned at the array's first index,
    and each element in the array represents your maximum jump length at that position.

    Return true if you can reach the last index, or false otherwise.
*/

public static class JumpGame
{
    public static bool Solution(int[] nums)
    {
        int desiredLength = 0;
        for (int positionIndex = nums.Length - 1; positionIndex > 0; positionIndex--)
        {
            if (nums[positionIndex] < desiredLength)
            {
                desiredLength += 1;
                continue;
            }
            desiredLength = 1;
        }

        return nums[0] >= desiredLength ? true : false;
    }
}

/*
[5,9,3,2,1,0,2,3,3,1,0,0]
 0 1 5 4 3 2 1 1 1 3 2 1

 */