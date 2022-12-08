namespace Problem4
{
  internal class Bird : Animal
  {
    private string name = "Zazu";
    public Bird(string name)
    {
      this.name = name;
      Console.WriteLine("I'm a bird and my name is " + name);
    }
    public void fly()
    {
      Console.WriteLine("I am able to fly by flapping my wings");
    }
  }
}