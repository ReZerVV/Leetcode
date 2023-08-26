namespace Leetcode.Test;

[TestClass]
public class CandyTest
{
    [TestMethod]
    public void CandyTestCase1()
    {
        int[] ratings = new int[] { 1, 0, 2 };

        int res = Candy.Solution(ratings); 
        
        Assert.AreEqual(5, res);
    }
    
    [TestMethod]
    public void CandyTestCase2()
    {
        int[] ratings = new int[] { 1, 2, 2 };

        int res = Candy.Solution(ratings); 
        
        Assert.AreEqual(4, res);
    }
}