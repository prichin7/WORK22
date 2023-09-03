using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_НОМЕР_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 5 || a == 10)
            {
                Console.WriteLine($"{a}");
            }
            else
            {
                Console.WriteLine("неизвестное число");
            }
        }
    }
}
