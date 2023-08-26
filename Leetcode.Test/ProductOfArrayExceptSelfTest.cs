namespace Leetcode.Test;

[TestClass]
public class ProductOfArrayExceptSelfTest
{
    [TestMethod]
    public void ProductOfArrayExceptSelfTestCase1()
    {
        int[] nums = new int[] { 1, 2, 3, 4 };

        int[] answer = ProductOfArrayExceptSelf.Solution(nums);

        CollectionAssert.AreEqual(new int[] { 24, 12, 8, 6 }, answer);
    }
    
    [TestMethod]
    public void ProductOfArrayExceptSelfTestCase2()
    {
        int[] nums = new int[] { -1, 1, 0, -3, 3 };

        int[] answer = ProductOfArrayExceptSelf.Solution(nums);

        CollectionAssert.AreEqual(new int[] { 0, 0, 9, 0, 0 }, answer);
    }
}