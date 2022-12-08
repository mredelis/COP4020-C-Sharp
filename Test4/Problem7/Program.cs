using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem7
{
  class Problem7
  {
    public static IEnumerable<int> linqPrimes(IEnumerable<int> input2)
    {
      IEnumerable<int> res;
      res = input2.Where(x => isPrime(x));
      return res;
    }

    public static bool isPrime(int number)
    {
      // if (number <= 1) return false;
      if (number == 2) return true;
      if (number % 2 == 0) return false;

      var limit = (int)Math.Floor(Math.Sqrt(number));

      for (int i = 3; i <= limit; i += 2)
        if (number % i == 0)
          return false;

      return true;
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers2 = { 30, 31, 40, 41, 50, 51, 60, 61, 70, 71, 72, 74, 75, 100, 101, 101, 200 };
      List<int> lst2 = numbers2.OfType<int>().ToList();

      var answer = Problem7.linqPrimes(lst2);
      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}
