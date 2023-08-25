namespace Leetcode.Solutions;

/*
    You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].

    Each element nums[i] represents the maximum length of a forward jump from index i. In other words, 
    if you are at nums[i], you can jump to any nums[i + j] where:
        0 <= j <= nums[i] and
        i + j < n

    Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that you can reach nums[n - 1].
*/

public static class JumpGameII
{
    public static int Solution(int[] nums)
    {
        int numberOfJumps = 0;
        int bestJumpIndex = 0;
        for (int positionIndex = nums.Length - 1; 
             positionIndex > 0; 
             positionIndex = bestJumpIndex, numberOfJumps++)
        {
            for (int jumpIndex = 0, desiredLength = positionIndex; 
                 jumpIndex < positionIndex;
                 jumpIndex++, desiredLength--)
            {
                if (nums[jumpIndex] >= desiredLength)
                {
                    bestJumpIndex = jumpIndex;
                    break;
                }
            }
        }

        return numberOfJumps;
    }
}

/*
         *
[2,3,1,1,4]:2
 4 3 2 1 0
 */