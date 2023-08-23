namespace Leetcode.Test;

[TestClass]
public class MajorityElementTest
{
    [TestMethod]
    public void MajorityElementTestCase1()
    {
        int[] nums = new int[] { 3, 2, 3 };

        int val = MajorityElement.Solution(nums);
        
        Assert.AreEqual(3, val);
    }
    
    [TestMethod]
    public void MajorityElementTestCase2()
    {
        int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };

        int val = MajorityElement.Solution(nums);
        
        Assert.AreEqual(2, val);
    }
}