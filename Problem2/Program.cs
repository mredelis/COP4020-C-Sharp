namespace Problem2
{
  class Problem2
  {
    public static IEnumerable<int> myFilter(IEnumerable<int> input)
    {
      IEnumerable<int> result;
      result = input.Where(x => x % 6 == 0).Where(x => x > 42).Select(x => x * x).Where(x => x % 2 == 0);

      return result;
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();
      var listForProblem = Enumerable.Range(1, 100).Select(i => rnd.Next() % 101);
      var answer = Problem2.myFilter(listForProblem);

      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}
