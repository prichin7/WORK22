using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clagna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3 любых числа чтобы получить среднее значение: ");
            double nomber = Convert.ToInt32(Console.ReadLine());
            double hd = Convert.ToInt32(Console.ReadLine());
            double qe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((nomber+hd+qe)/3);
            
            

        }
    }
}
