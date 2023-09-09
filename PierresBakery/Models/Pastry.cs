namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
    public int Total {get;}

    public Pastry()
    {
      Total = 0;
    }
    public override int CalculateTotal(int amount)
    {
      int pastryCost = 0;
      for (int i = 1; i <= amount; i++)
      {
        if (i % 3 == 0)
        {
          continue;
        }
        else
        {
          pastryCost += 2;
        }
      }
      return pastryCost;
    }
  }
}