using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaDaChA_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double z = 100;
            double x = 200;
            double c = Convert.ToDouble(Console.ReadLine());
            

      //      Console.WriteLine("Сколько вы планируете держать в банке свои деньги?");
            

            for (int i = 1; i <= 10; i++) 
            {
               
                Console.WriteLine(i);


                if (z <= c && x >= c)
                {
                    Console.WriteLine(string.Format("{0:F2}", c * 1.05));
                    c *= 1.05;
                }
                else if (z > c)
                {
                    Console.WriteLine(string.Format("{0:F2}", c * 1.07));
                    c *= 1.07;
                }
                else if (x < c)
                {
                    Console.WriteLine(string.Format("{0:F2}", c * 1.1));
                    c *= 1.1;
                }
                if (i == 5)
                {
                    Console.WriteLine("желаете ли вы вывести деньги сейчас?");
                    Console.WriteLine("1. \"Нет, спасибо\"");
                    Console.WriteLine("2. Внести еще денег");
                    Console.WriteLine("3. Вывести все средства\n"); 
                    Console.Write("Введите нужный НОМЕР варианта: ");

                    int trans = Convert.ToInt32(Console.ReadLine());
                    if (trans == 1)
                    {

                    }
                    else if (trans == 2)
                    {
                        Console.WriteLine("какую сумму вы хотите внести: ");
                        c += Convert.ToDouble(Console.ReadLine());
                    }
                    else if (trans == 3)
                    {
                        Console.WriteLine("Накопления приостановлены");
                        break;
                    }
                }
            }
        }
        
    }
}
