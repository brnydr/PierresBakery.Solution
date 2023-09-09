using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void CalculateTotal_ReturnsNumber_Int()
    {
      Bread newBread = new Bread();
      int total = 5;
      int amount = 1;
      Assert.AreEqual(newBread.CalculateTotal(amount), total);
    }

    [TestMethod]
    public void CalculateTotal_ReturnsTotalFromInput_Int()
    {
      Bread newBread = new Bread();
      int input = 2;
      int total = 10;
      Assert.AreEqual(total, newBread.CalculateTotal(input));
    }
  }
}