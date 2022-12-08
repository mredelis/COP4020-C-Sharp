using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem6
{
  class Problem6
  {
    public static IEnumerable<int> findOdds(IEnumerable<int> input3)
    {
      IEnumerable<int> res;
      res = input3.Select(x => x * x).Where(x => x % 2 != 0);
      return res;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers3 = { -5, -6, -7, -8, 47, 50, 60, 1000, 2000, 3000 };
      List<int> lst3 = numbers3.OfType<int>().ToList();

      var answer = Problem6.findOdds(lst3);
      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}
