namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    public int Total {get; set;}
    public Bread()
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
          this.Total += 5;
        }
      }
      return this.Total;
    }
  }
}