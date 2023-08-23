namespace Leetcode.Test;

[TestClass]
public class BestTimeToBuyAndSellStockTest
{
    [TestMethod]
    public void BestTimeToBuyAndSellStockTestCase1()
    {
        int[] prices = new[] { 7, 1, 5, 3, 6, 4 };

        int profit = BestTimeToBuyAndSellStock.Solution(prices);
        
        Assert.AreEqual(5, profit);
    }
    
    [TestMethod]
    public void BestTimeToBuyAndSellStockTestCase2()
    {
        int[] prices = new[] { 7, 6, 4, 3, 1 };

        int profit = BestTimeToBuyAndSellStock.Solution(prices);
        
        Assert.AreEqual(0, profit);
    }
}