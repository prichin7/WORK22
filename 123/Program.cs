using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnPrichin7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minLine = 100;
            int maxLine = 200;

            double minZone = 1.05;
            double midZone = 1.07;
            double maxZone = 1.1;

            int time;
            double userMoney;
            double profit = 0;

            int choise;

            Console.WriteLine("Приветствуем в нашем банке, наш дорогой гость\n" +
                "Я слышал вы хотите положить некую сумму на накопительный счет\n" +
                "Сколько вы желаете внести?\n");
            Console.Write("Введите желаемую сумму: ");

            userMoney = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("На какой срок вы бы хотели внести эту сумму?\n");
            Console.Write("Введите желаемое время(в годах): ");

            time = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= time; i++)
            {
                if (userMoney < minLine) { profit += userMoney * minZone - userMoney; userMoney *= minZone; }
                else if (userMoney > maxLine) { profit += userMoney * maxZone - userMoney; userMoney *= maxZone; }
                else { profit += userMoney * midZone - userMoney; userMoney *= midZone; }

                Console.WriteLine($"{i} год. Денег на счету: {string.Format("{0:F2}", userMoney)}");

                if (i % 5 == 0 && i != time)
                {
                    Console.WriteLine("\nВозможно вы желаете вывести деньги раньше времени? Уверяю Вас, Ваши проценты не сгорят.\n" +
                        "Или возможно вы желаете увеличить прибыль положив еще больше средств на ваш счет?\n");
                    Console.WriteLine("1. \"Нет, спасибо\"");
                    Console.WriteLine("2. Внести еще денег");
                    Console.WriteLine("3. Вывести все средства\n");
                    Console.Write("Введите нужный НОМЕР варианта: ");

                    choise = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (choise == 1)
                    {

                    }
                    else if (choise == 2)
                    {
                        Console.Write("Введите какую сумму вы бы хотели внести: ");
                        userMoney += Convert.ToDouble(Console.ReadLine());
                    }
                    else if (choise == 3)
                    {
                        break;
                    }
                }

                Thread.Sleep(150);

            }
            Console.WriteLine("\n----------------------------------------------------------------------\n");
            Console.WriteLine($"Ваш баланс на данный момент составляет {string.Format("{0:F2}", userMoney)}");
            Console.WriteLine($"Ваша прибыль за весь срок: {profit}");
        }
    }
}