namespace Problem1
{
  class Student
  {
    private int admno;
    private string? sname;
    private float eng, math, science;
    private float total;
    private float ctotal()
    {
      return this.eng + this.math + this.science;
    }

    public void Takedata()
    {
      Console.WriteLine("Enter admission number: ");
      this.admno = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter student name: ");
      this.sname = Console.ReadLine();

      Console.WriteLine("Enter english grade: ");
      this.eng = (float)Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter math grade: ");
      this.math = (float)Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter science grade: ");
      this.science = (float)Convert.ToDouble(Console.ReadLine());

      this.total = ctotal();
    }

    public void Showdata()
    {
      Console.WriteLine("You have entered ");
      Console.WriteLine("Admission number: {0}\nName: {1}\nEnglish: {2}\nMath: {3}\nScience: {4}\nTotal: {5}", this.admno, this.sname, this.eng, this.math, this.science, this.total);
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
