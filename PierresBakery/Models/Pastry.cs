namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
  public override int CalculateTotal(int amount)
  {
    return 2 * amount;
  }
  }
}