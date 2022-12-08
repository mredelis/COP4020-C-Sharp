using System;
using System.IO;

namespace Problem3
{
  class Program
  {
    static void Main(string[] args)
    {
      int count = 0;

      if (File.Exists("STORY.TXT"))
      {
        // read content line by line
        string[] lines = File.ReadAllLines("STORY.TXT");
        foreach (string line in lines)
        {
          if (line[0] != 'A')
          {
            count++;
          }
        }
        Console.WriteLine("Number of lines not starting with A are: " + count);
      }
    }
  }
}