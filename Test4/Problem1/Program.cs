namespace Problem1
{
  class Student
  {
    private int admno;
    private string? sname;
    private float eng, math, science;
    private float total = 0;
    private float ctotal()
    {
      float marks = (eng + math + science);
      total = marks;
      return total;
    }

    public void Takedata()
    {
      Console.WriteLine("Enter admission number: ");
      admno = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter student name: ");
      sname = Console.ReadLine();

      Console.WriteLine("Enter english grade: ");
      eng = (float)Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter math grade: ");
      math = (float)Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter science grade: ");
      science = (float)Convert.ToDouble(Console.ReadLine());

      total = ctotal();
    }

    public void Showdata()
    {
      Console.WriteLine("You have entered ");
      Console.WriteLine("Admission number: {0}\nName: {1}\nEnglish: {2}\nMath: {3}\nScience: {4}\nTotal: {4}", admno, sname, eng, math, science, total);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();
      student.Takedata();
      student.Showdata();
    }
  }
}
