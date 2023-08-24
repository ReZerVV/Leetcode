namespace Leetcode.Test;

[TestClass]
public class StrStrTest
{
    [TestMethod]
    public void StrStrTestCase1()
    {
        string haystack = "sadbutsad",
               needle = "sad";

        int res = StrStr.Solution(haystack, needle);
        
        Assert.AreEqual(0, res);
    }
    
    [TestMethod]
    public void StrStrTestCase2()
    {
        string haystack = "leetcode",
            needle = "leeto";

        int res = StrStr.Solution(haystack, needle);
        
        Assert.AreEqual(-1, res);
    }
}