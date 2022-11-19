using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    internal class Cat : Animal
    {
        private string name = "Simba";
        public Cat(string name)
        {
            this.name = name;
            Console.WriteLine("I'm a cat and my name is " + name);
        }
        public void sing()
        {
            Console.WriteLine("Cats meow");
        }
        public void wash()
        {
            Console.WriteLine("Cats DON'T enjoy bathing daily");
        }
        public void turnAround()
        {
            Console.WriteLine("Cats are turning RIGHT");
        }
    }
}
