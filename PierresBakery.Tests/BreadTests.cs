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
    public void CalculateTotal_ReturnsTotal_Int()
    {
      Bread newBread = new Bread();
      int total = 5;
      Assert.AreEqual(newBread.CalculateTotal(), total);
    }
  }
}