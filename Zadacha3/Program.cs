using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число: ");

            int z = Convert.ToInt32(Console.ReadLine());
            if (z > 256)
            {
                Console.WriteLine("Ваше число больше 256");

            }
            else if (z < 256)
            {
                Console.WriteLine("Ваше число меньше 256");
            }
            else
            {
                Console.WriteLine("Ваше число равно 256");
            }
            if (true) Console.WriteLine("число 1");
        }
    }
}
