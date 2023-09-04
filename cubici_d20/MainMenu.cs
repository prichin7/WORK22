using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubici_d20
{
    internal class MainMenu
    {
        private int cnslWidth;
        private char pixel;
        private ConsoleColor back;
        private ConsoleColor front;
        public string programName = "Dice thrower";

        public MainMenu()
        {
            cnslWidth = Console.WindowWidth;
            pixel = '█';
            back = ConsoleColor.Red;
            front = ConsoleColor.Black;

            drawDice();
            
            Console.SetCursorPosition(cnslWidth / 2 - programName.Length / 2, 14);
            Console.Write(programName);

            Menu();
        }
        
        private void Menu()
        {
            string start = "Start";
            string setting = "Setting";

            Console.SetCursorPosition(cnslWidth / 2 - start.Length / 2 , 16);
            Console.Write(start);

            Console.SetCursorPosition(cnslWidth / 2 - setting.Length / 2, 18);
            Console.Write(setting);
        }

        private void drawDice()
        {
            drawBack();
            drawFront();
        }

        private void drawBack()
        {
            Console.ForegroundColor = back;

            for (int i = cnslWidth / 2 - 13; i <= cnslWidth / 2 + 13; i++)
            {
                for (int j = 2; j <= 12; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(pixel);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        private void drawFront()
        {
            draw2();
            draw0();
        }

        private void draw2()
        {
            Console.ForegroundColor = front;

            for (int i = cnslWidth / 2 - 10; i <= cnslWidth / 2 - 2; i++)
            {
                for(int j = 4;j <= 10; j++)
                {
                    if (j == 4 || j == 7 || j == 10)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(pixel);
                    }
                }
            }

            Console.SetCursorPosition (cnslWidth/ 2 - 3, 5);
            Console.Write(pixel);
            Console.Write(pixel);
            Console.SetCursorPosition(cnslWidth / 2 - 3, 6);
            Console.Write(pixel);
            Console.Write(pixel);
            Console.SetCursorPosition(cnslWidth / 2 - 10, 8);
            Console.Write(pixel);
            Console.Write(pixel);
            Console.SetCursorPosition(cnslWidth / 2 - 10, 9);
            Console.Write(pixel);
            Console.Write(pixel);

            Console.ForegroundColor = ConsoleColor.White;
        }

        private void draw0()
        {
            Console.ForegroundColor = front;

            for (int i = cnslWidth / 2 + 2; i <+ cnslWidth / 2 + 10; i++)
            {
                for (int j = 4; j <= 10; j++)
                {
                    if (i == cnslWidth / 2 + 2 || i == cnslWidth / 2 + 9 || j == 4 || j == 10)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(pixel);
                        Console.Write(pixel);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
