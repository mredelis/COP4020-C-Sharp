namespace Problem4
{
  internal class Dog : Animal
  {
    private string name = "Lassie";
    public Dog(string name)
    {
      this.name = name;
      Console.WriteLine("I'm a dog and my name is " + name);
    }
    public void bark()
    {
      Console.WriteLine("Woof");
    }
  }
}