namespace Leetcode.Test;

[TestClass]
public class RemoveElementTest
{
    [TestMethod]
    public void RemoveElementTestCase1()
    {
        int[] nums = new int[] { 3, 2, 2, 3 };
        int val = 3;
        
        int k = RemoveElement.Solution(nums, val);

        int[] actualNums = new int[k];
        Array.Copy(nums, 0, actualNums, 0, k);
        
        Assert.AreEqual(2, k);
        CollectionAssert.DoesNotContain(actualNums, val);
    }
    
    [TestMethod]
    public void RemoveElementTestCase2()
    {
        int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        
        int k = RemoveElement.Solution(nums, val);

        int[] actualNums = new int[k];
        Array.Copy(nums, 0, actualNums, 0, k);
        
        Assert.AreEqual(5, k);
        CollectionAssert.DoesNotContain(actualNums, val);
    }
}