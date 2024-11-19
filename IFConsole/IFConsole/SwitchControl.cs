using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFConsole
{
    internal class SwitchControl
    {
        public void Control(int i, int a, int b) 
        {
            switch(i)
            {
                case 0:
                    Console.WriteLine("Числа рвны");
                    break;

                case 1:
                    Console.WriteLine($"{a} < {b}");
                    break;

                case 2:
                    Console.WriteLine($"{a} > {b}");
                    break;
            }
        }
    }
}
