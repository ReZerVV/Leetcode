namespace Leetcode.Solutions;

/*
    You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

    On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. 
    However, you can buy it then immediately sell it on the same day.

    Find and return the maximum profit you can achieve.
*/

public static class BestTimeToBuyAndSellStockII
{
    public static int Solution(int[] prices)
    {
        if(prices.Length < 2) {return 0;}
        int min = prices[0];
        int max = prices[0];
        int sum = 0;
        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i] > max)
            {
                max = prices[i];
                continue;
            }
            if(prices[i] < max)
            {
                sum += max - min;
                min = prices[i];
                max = prices[i];
            }
        }
        sum+= max - min;
        
        return sum;
    }
}