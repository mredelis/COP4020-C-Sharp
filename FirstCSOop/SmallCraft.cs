using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    internal class SmallCraft : IUFO
    {
        public void fly() 
        {
            Console.WriteLine("Small craft can't fly around the globe");
        }
        public void goToHyperspace() 
        {
            Console.WriteLine("Small craft can't go to hyperspace");
        }
        public void land() 
        {
            Console.WriteLine("Small craft, of course I can land");
        }
    }
}
