namespace Leetcode.Test;

[TestClass]
public class JumpGameIITest
{
    [TestMethod]
    public void JumpGameIITestCase1()
    {
        int[] nums = new int[] { 2, 3, 1, 1, 4 };

        int res = JumpGameII.Solution(nums);
        
        Assert.AreEqual(2, res);
    }
    
    [TestMethod]
    public void JumpGameIITestCase2()
    {
        int[] nums = new int[] { 2, 3, 0, 1, 4 };

        int res = JumpGameII.Solution(nums);
        
        Assert.AreEqual(2, res);
    }
}