namespace Problem2
{
  class Batsman
  {
    private int bcode;
    private string? bname;
    private int innings, notout, runs;
    private float batavg;
    private void calcavg()
    {
      batavg = runs / (innings + notout);
    }

    public void readdata()
    {
      Console.WriteLine("Enter batsman code: ");
      bcode = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter batsman name: ");
      bname = Console.ReadLine();

      Console.WriteLine("Enter innings: ");
      innings = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter notout: ");
      notout = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter runs: ");
      runs = Convert.ToInt32(Console.ReadLine());

      calcavg();
    }

    public void displaydata()
    {
      Console.WriteLine("You have entered ");
      Console.WriteLine("Batsman codde: {0}\nBatsman name: {1}\nInnings: {2}\nNotout: {3}\nRuns: {4}\nBating avarage: {4}", bcode, bname, innings, notout, runs, batavg);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Batsman batsman = new Batsman();
      batsman.readdata();
      batsman.displaydata();
    }
  }
}
