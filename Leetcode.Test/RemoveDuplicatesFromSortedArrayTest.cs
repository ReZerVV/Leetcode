namespace Leetcode.Test;

[TestClass]
public class RemoveDuplicatesFromSortedArrayTest
{
    [TestMethod]
    public void RemoveDuplicatesFromSortedArrayTestCase1()
    {
        int[] nums = new int[] { 1, 1, 2 };
        
        int k = RemoveDuplicatesFromSortedArray.Solution(nums);

        int[] actualNums = new int[k];
        Array.Copy(nums, 0, actualNums, 0, k);
        
        Assert.AreEqual(2, k);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, actualNums);
    }
    
    [TestMethod]
    public void RemoveDuplicatesFromSortedArrayTestCase2()
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        
        int k = RemoveDuplicatesFromSortedArray.Solution(nums);

        int[] actualNums = new int[k];
        Array.Copy(nums, 0, actualNums, 0, k);
        
        Assert.AreEqual(5, k);
        CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4 }, actualNums);
    }
}