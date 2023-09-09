namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
  
    public override int CalculateTotal(int amount)
    {
      return amount * 5;
    }
  }
}