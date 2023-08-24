namespace Leetcode.Test;

[TestClass]
public class RomanToIntegerTest
{
    [TestMethod]
    public void RomanToIntegerTestCase1()
    {
        string s = "III";
        
        int res = RomanToInteger.Solution(s);
        
        Assert.AreEqual(3, res);
    }
    
    [TestMethod]
    public void RomanToIntegerTestCase2()
    {
        string s = "LVIII";
        
        int res = RomanToInteger.Solution(s);
        
        Assert.AreEqual(58, res);
    }
    
    [TestMethod]
    public void RomanToIntegerTestCase3()
    {
        string s = "MCMXCIV";
        
        int res = RomanToInteger.Solution(s);
        
        Assert.AreEqual(1994, res);
    }
}