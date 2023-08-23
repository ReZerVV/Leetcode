namespace Leetcode.Test;

[TestClass]
public class MergeSortedArrayTest
{
    [TestMethod]
    public void MergeSortedArrayTestCase1()
    {
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 },
              nums2 = new int[] {2,5,6};
        
        int m = 3,
            n = 3;
        
        MergeSortedArray.Solution(nums1, m, nums2, n);
        
        CollectionAssert.AreEqual(new int[] {1,2,2,3,5,6}, nums1);
    }
    
    [TestMethod]
    public void MergeSortedArrayTestCase2()
    {
        int[] nums1 = new int[] {2,0},
            nums2 = new int[] {1};
        
        int m = 1,
            n = 1;
        
        MergeSortedArray.Solution(nums1, m, nums2, n);
        
        CollectionAssert.AreEqual(new int[] {1,2}, nums1);
    }
}