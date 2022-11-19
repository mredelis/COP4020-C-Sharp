using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    internal class BossCraft : IUFO
    {
        public void fly()
        {
            Console.WriteLine("Boss craft CAN fly around the globe");
        }
        public void goToHyperspace()
        {
            Console.WriteLine("Boss craft CAN go to hyperspace");
        }
        public void land()
        {
            Console.WriteLine("Boss craft, of course I can land");
        }
    }
}
