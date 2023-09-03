using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 любых числа и мы их сравним");
            Console.WriteLine("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
                if (a > b)
                {
                    Console.WriteLine($"{a} больше {b}");
                }

                else if (a < b)
                {
                    Console.WriteLine($"{a} меньше {b}");
                }

            else
                {
                    Console.WriteLine("оба числа равны");
                }
            
        }
    }
}
