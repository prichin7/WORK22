using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_false
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую у порога элитного клуба Эксбис, ваши документы пожалуйста:");     //вывод текста
            int z = 18;
            int x = 35;
            int c = Convert.ToInt32(Console.ReadLine());    //пользователь вводит число
            
            
            if (c >= z && c < x)  //&& = логическая "и"
            {
                Console.WriteLine("Можете проходить, бич");
            }
            else
            {
                Console.WriteLine("Иди нахуй, малолетних стариков не пускаем");
            }
        } 

    }
}
