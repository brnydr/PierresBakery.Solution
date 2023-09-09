namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
    public int Total {get; set;}

    public Pastry()
    {
      Total = 0;
    }
    public override int CalculateTotal(int amount)
    {
      for (int i = 1; i <= amount; i++)
      {
        if (i % 3 == 0)
        {
          continue;
        }
        else
        {
          this.Total += 2;
        }
      }
      return this.Total;
    }
  }
}