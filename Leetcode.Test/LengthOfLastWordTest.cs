namespace Leetcode.Test;

[TestClass]
public class LengthOfLastWordTest
{
    [TestMethod]
    public void LengthOfLastWordTestCase1()
    {
        string s = "Hello World";

        int res = LengthOfLastWord.Solution(s);
        
        Assert.AreEqual(5, res);
    }
    
    [TestMethod]
    public void LengthOfLastWordTestCase2()
    {
        string s = "   fly me   to   the moon  ";

        int res = LengthOfLastWord.Solution(s);
        
        Assert.AreEqual(4, res);
    }
    
    [TestMethod]
    public void LengthOfLastWordTestCase3()
    {
        string s = "luffy is still joyboy";

        int res = LengthOfLastWord.Solution(s);
        
        Assert.AreEqual(6, res);
    }
}