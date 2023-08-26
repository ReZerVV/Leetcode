namespace Leetcode.Test;

[TestClass]
public class GasStationTest
{
    [TestMethod]
    public void GasStationTestCase1()
    {
        int[] gas = new int[] { 1, 2, 3, 4, 5 },
            cost = new int[] { 3, 4, 5, 1, 2 };

        int res = GasStation.Solution(gas, cost);
        
        Assert.AreEqual(3, res);
    }
    
    [TestMethod]
    public void GasStationTestCase2()
    {
        int[] gas = new int[] { 2, 3, 4 },
            cost = new int[] { 3, 4, 3 };

        int res = GasStation.Solution(gas, cost);
        
        Assert.AreEqual(-1, res);
    }
}