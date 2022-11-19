namespace FirstCSOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird tweety = new Bird("Tweety");
            tweety.move();
            tweety.sleep();
            tweety.eat();
            tweety.sing();
            tweety.wash();
            tweety.turnAround();

            Cat mufasa = new Cat("Mufasa");
            mufasa.move();
            mufasa.sleep();
            mufasa.eat();
            mufasa.sing();
            mufasa.wash();
            mufasa.turnAround();

            Dog balto = new Dog("Balto");
            balto.move();
            balto.sleep();
            balto.eat();
            balto.sing();
            balto.wash();
            balto.turnAround();

            SmallCraft small = new SmallCraft();
            small.fly();
            small.goToHyperspace();
            small.land();

            LargeCraft large = new LargeCraft();
            large.fly();
            large.goToHyperspace();
            large.land();

            BossCraft boss = new BossCraft();
            boss.fly();
            boss.goToHyperspace();
            boss.land();
        }
    }
}