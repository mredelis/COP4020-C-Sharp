namespace Problem4
{
  internal class Turtle : Animal
  {
    private string name = "Donatello";
    public Turtle(string name)
    {
      this.name = name;
      Console.WriteLine("I'm a turtle and my name is " + name);
    }
    public void retract()
    {
      Console.WriteLine("I am able to retract my head sideways");
    }
  }
}