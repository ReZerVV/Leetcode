namespace Leetcode.Test;

[TestClass]
public class JumpGameTest
{
    [TestMethod]
    public void JumpGameTestCase1()
    {
        int[] nums = new int[] { 2, 3, 1, 1, 4 };

        bool res = JumpGame.Solution(nums);
        
        Assert.IsTrue(res);
    }
    
    [TestMethod]
    public void JumpGameTestCase2()
    {
        int[] nums = new int[] { 3, 2, 1, 0, 4 };

        bool res = JumpGame.Solution(nums);
        
        Assert.IsFalse(res);
    }
    
    [TestMethod]
    public void JumpGameTestCase3()
    {
        int[] nums = new int[] { 0 };

        bool res = JumpGame.Solution(nums);
        
        Assert.IsTrue(res);
    }
    
    [TestMethod]
    public void JumpGameTestCase4()
    {
        int[] nums = new int[] { 5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0 };

        bool res = JumpGame.Solution(nums);
        
        Assert.IsTrue(res);
    }
}