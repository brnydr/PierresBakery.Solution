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
    [TestMethod]
    public void CalculateTotal_ReturnsTotalWithDiscounts_Int()
    {
      Pastry newPastry = new Pastry();
      int input = 8;
      int total = 12;
      Assert.AreEqual(total, newPastry.CalculateTotal(input));
    }
    [TestMethod]
    public void GetTotal_ReturnTotalProperty_Int()
    {
      Pastry newPastry = new Pastry();
      int zero = 0;
      Assert.AreEqual(zero, newPastry.Total);
    }

    [TestMethod]
    public void SetTotal_SetTotalProperty_Int()
    {
      Pastry newPastry = new Pastry();
      int input = 5;
      newPastry.Total = input;
      Assert.AreEqual(input, newPastry.Total);
    }
  }
}