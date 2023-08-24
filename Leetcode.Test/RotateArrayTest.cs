using RotateArray = Leetcode.Solutions.RotateArray;

namespace Leetcode.Test;

[TestClass]
public class RotateArrayTest
{
    [TestMethod]
    public void RotateArrayTestCase1()
    {
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        
        RotateArray.Solution(nums, k);

        CollectionAssert.AreEqual(new int[] { 5, 6, 7, 1, 2, 3, 4 }, nums);
    }
    
    [TestMethod]
    public void RotateArrayTestCase2()
    {
        int[] nums = new int[] { -1, -100, 3, 99 };
        int k = 2;
        
        RotateArray.Solution(nums, k);

        CollectionAssert.AreEqual(new int[] { 3,99,-1,-100 }, nums);
    }
}