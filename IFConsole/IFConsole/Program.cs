using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFConsole
{
    internal class Program
    {
        static ProverkaType proverka = new ProverkaType();
        static SwitchControl switchControl = new SwitchControl();

        static int a;
        static int b;
        static void Main(string[] args)
        {
            start:
            a = proverka.Type<int>("Введите целое число => ");
            b = proverka.Type<int>("Введите целое число => ");

            if (a == b) 
            {
                switchControl.Control(0, a, b);
                //Console.WriteLine("Числа рвны");
            }

            else if (a < b)
            {
                switchControl.Control(1, a, b);
                //Console.WriteLine($"{a} < {b}");
            }

            else if (a > b)
            {
                switchControl.Control(2, a, b);
                //Console.WriteLine($"{a} > {b}");
            }
            Console.ReadKey();

            Console.Clear();
            goto start;
        }
    }
}
