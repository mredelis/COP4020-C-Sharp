namespace Problem4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Bird tweety = new Bird("Tweety");
      tweety.breath();
      tweety.fly();

      Turtle leonardo = new Turtle("Leonardo");
      leonardo.breath();
      leonardo.retract();

      Dog balto = new Dog("Balto");
      balto.breath();
      balto.bark();
    }
  }
}