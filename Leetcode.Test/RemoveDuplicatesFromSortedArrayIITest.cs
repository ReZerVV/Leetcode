namespace Leetcode.Test;

[TestClass]
public class RemoveDuplicatesFromSortedArrayIITest
{
    [TestMethod]
    public void RemoveDuplicatesFromSortedArrayIITestCase1()
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

        int k = RemoveDuplicatesFromSortedArrayII.Solution(nums);
        
        int[] actualNums = new int[k];
        Array.Copy(nums, 0, actualNums, 0, k);
        
        Assert.AreEqual(7, k);
        CollectionAssert.AreEqual(new int[] { 0, 0, 1, 1, 2, 3, 3 }, actualNums);
    }
}