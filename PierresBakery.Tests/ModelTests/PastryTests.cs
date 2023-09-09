using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void CalculateTotal_ReturnsNumber_Int()
    {
      Pastry newPastry = new Pastry();
      int total = 2;
      int amount = 1;
      Assert.AreEqual(newPastry.CalculateTotal(amount), total);
    }

    [TestMethod]
    public void CalculateTotal_ReturnsTotalFromInput_Int()
    {
      Pastry newPastry = new Pastry();
      int input = 2;
      int total = 4;
      Assert.AreEqual(total, newPastry.CalculateTotal(input));
    }
  }
}