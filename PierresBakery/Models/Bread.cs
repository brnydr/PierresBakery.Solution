namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    public int Total { get; }


    public Bread()
    {
      Total = 0;
    }
  
    public override int CalculateTotal(int amount)
    {

      int breadCost = 0;

      for (int i = 1; i <= amount; i++)
      {
        if (i % 3 == 0)
        {
          continue;
        }
        else
        {
          breadCost += 5;
        }
      }
      return breadCost;
    }
  }
}