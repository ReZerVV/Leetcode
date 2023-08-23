namespace Leetcode.Solutions;

/*
    You are given an array prices where prices[i] is the price of a given stock on the ith day.

    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
 */

public static class BestTimeToBuyAndSellStock
{
    public static int Solution(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        
        for (int pricesIndex = 0; pricesIndex < prices.Length; pricesIndex++) 
        {
            if (prices[pricesIndex] < minPrice) 
            {
                minPrice = prices[pricesIndex];
            }
            
            int profit = prices[pricesIndex] - minPrice;
            if (profit > maxProfit) 
            {
                maxProfit = profit;
            }
        }
        
        return maxProfit;
    }
}