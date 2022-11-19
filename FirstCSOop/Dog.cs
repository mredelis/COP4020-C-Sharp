using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    internal class Dog : Animal
    {
        private string name = "Lassie";
        public Dog(string name) 
        {
            this.name = name;
            Console.WriteLine("I'm a dog and my name is " + name);
        }
        public void sing()
        {
            Console.WriteLine("Woof");
        }
        public void wash()
        {
            Console.WriteLine("Dogs enjoy bathing once in a blue moon");
        }
        public void turnAround()
        {
            Console.WriteLine("Dogs are turning AROUND");
        }
    }
}
