namespace Problem3
{
  class Problem3
  {
    public static IEnumerable<int> merge(IEnumerable<int> input1, IEnumerable<int> input2, IEnumerable<int> input3, IEnumerable<int> input4)
    {
      IEnumerable<int> result;

      result = input1.Intersect(input2).Intersect(input3).Intersect(input4).Where(i => i % 10 == 0);

      return result;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();

      var list1 = Enumerable.Range(1, 15).Select(i => rnd.Next() % 16);
      var list2 = Enumerable.Range(2, 42).Select(i => rnd.Next() % 43).Where(i => (i % 2 == 0));
      var list3 = Enumerable.Range(3, 21).Select(i => rnd.Next() % 22).Where(i => (i % 2 != 0));
      var list4 = Enumerable.Range(5, 105).Select(i => rnd.Next() % 106).Where(i => (i % 5 == 0));

      var answer = Problem3.merge(list1, list2, list3, list4);

      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}

