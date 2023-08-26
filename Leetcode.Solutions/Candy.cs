namespace Leetcode.Solutions;

/*
    There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.

    You are giving candies to these children subjected to the following requirements:
        Each child must have at least one candy.
        Children with a higher rating get more candies than their neighbors.

    Return the minimum number of candies you need to have to distribute the candies to the children.
*/

public static class Candy
{
    public static int Solution(int[] ratings)
    {
        int[] numberOfCandy = new int[ratings.Length];
        for (int index = 0; index < numberOfCandy.Length; index++)
        {
            numberOfCandy[index] = 1;
        }

        for (int index = 1; index < ratings.Length; index++) 
        {
            if (ratings[index - 1] < ratings[index])
            {
                numberOfCandy[index] = numberOfCandy[index - 1] + 1;
            }
        }
        
        for (int index = ratings.Length - 1; index >= 1; index--) 
        {
            if (ratings[index - 1] > ratings[index])
            {
                numberOfCandy[index - 1] = numberOfCandy[index] + 1;
            }
        }
        
        return numberOfCandy.Sum();
    }
}