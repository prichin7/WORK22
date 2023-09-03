using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любые 2 числа с клавиатуры");

            Console.WriteLine("Введите первое число: ");

            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            int x = Convert.ToInt32(Console.ReadLine());


            if (x < z)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (x > z)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else
            {
                Console.WriteLine("числа равны");
            }
        }
    }
}
