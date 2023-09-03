using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_номер_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите чило от 5 до 10");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 5 && a <= 10)
            {
                Console.WriteLine($"{a}, неплохое число");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        
    }
}
