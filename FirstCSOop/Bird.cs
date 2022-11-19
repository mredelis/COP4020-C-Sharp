using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    internal class Bird : Animal
    {
        private string name = "Zazu";
        public Bird(string name)
        {
            this.name = name;
            Console.WriteLine("I'm a bird and my name is " + name);
        }
        public void sing() 
        {
            Console.WriteLine("Birds chirp and warble");
        }
        public void wash() 
        {
            Console.WriteLine("Birds enjoy bathing daily");
        }
        public void turnAround() 
        {
            Console.WriteLine("Birds are turning LEFT");
        }
    }
}
