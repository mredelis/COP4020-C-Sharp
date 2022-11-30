namespace Problem1
{
  class Problem1
  {
    public static IEnumerable<int> myFilter(IEnumerable<int> input)
    {
      IEnumerable<int> result;
      result = input.Where(x => x % 5 == 0).Where(x => x < 50).Select(x => x * x * x).Where(x => x % 2 != 0);

      return result;
    }

  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random(5);
      var listForProblem = Enumerable.Range(1, 100).Select(i => rnd.Next() % 101);
      //var listForProblem = Enumerable.Range(1, 10);
      var answer = Problem1.myFilter(listForProblem);
      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}
