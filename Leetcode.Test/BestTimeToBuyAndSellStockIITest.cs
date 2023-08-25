namespace Leetcode.Test;

[TestClass]
public class BestTimeToBuyAndSellStockIITest
{
    [TestMethod]
    public void BestTimeToBuyAndSellStockIITestCase1()
    {
        int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

        int res = BestTimeToBuyAndSellStockII.Solution(prices);
        
        Assert.AreEqual(7, res);
    }
    
    [TestMethod]
    public void BestTimeToBuyAndSellStockIITestCase2()
    {
        int[] prices = new int[] { 1, 2, 3, 4, 5 };

        int res = BestTimeToBuyAndSellStockII.Solution(prices);
        
        Assert.AreEqual(4, res);
    }
    
    [TestMethod]
    public void BestTimeToBuyAndSellStockIITestCase3()
    {
        int[] prices = new int[] { 7, 6, 4, 3, 1 };

        int res = BestTimeToBuyAndSellStockII.Solution(prices);
        
        Assert.AreEqual(0, res);
    }
}