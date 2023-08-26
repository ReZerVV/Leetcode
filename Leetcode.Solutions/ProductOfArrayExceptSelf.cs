namespace Leetcode.Solutions;

/*
    Given an integer array nums, return an array answer such that answer[i] is equal to the product 
    of all the elements of nums except nums[i].

    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

    You must write an algorithm that runs in O(n) time and without using the division operation.
*/

public static class ProductOfArrayExceptSelf
{
    public static int[] Solution(int[] nums)
    {
        int number0 = 0;
        int product = 1;
        int[] answer = new int[nums.Length];

        foreach( int num in nums ){
            if(num == 0) {
                number0++;
                continue;
            }
            product*=num;
        }

        for(int i=0; i<nums.Length; i++){
            if(number0 > 0 && nums[i] != 0 || number0 >= 2 && nums[i] == 0) answer[i] = 0;
            else if(number0 == 1 && nums[i] == 0) answer[i] = product;
            else answer[i] = product/nums[i];
        }

        return answer;
    }
}