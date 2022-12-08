using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem5
{
  class Problem5
  {
    public static IEnumerable<int> findOddsMultOfFive(IEnumerable<int> input1, IEnumerable<int> input2)
    {
      IEnumerable<int> res;
      res = input1.Union(input2).Where(x => x % 5 == 0).Where(x => x % 2 != 0);
      return res;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers1 = { 1, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 29, 30, 31, 32, 33 };
      int[] numbers2 = { 30, 31, 40, 41, 50, 51, 60, 61, 70, 71, 72, 74, 75, 100, 101, 101, 200 };

      List<int> lst1 = numbers1.OfType<int>().ToList();
      List<int> lst2 = numbers2.OfType<int>().ToList();

      var answer = Problem5.findOddsMultOfFive(lst1, lst2);

      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}