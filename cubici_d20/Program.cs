using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubici_d20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MainMenu mainMenu = new MainMenu();
            interactMenu();

            void interactMenu()
            {
                string start = "Start";
                string setting = "Setting";
                char arrow = '→';
                int increment = 0;
                ConsoleKey management;

                Console.SetCursorPosition(Console.WindowWidth / 2 - start.Length / 2 - 2, 16);
                Console.Write(arrow);

                while (true)
                {
                    int x = Console.CursorLeft;
                    int y = Console.CursorTop;

                    management = Console.ReadKey().Key;

                     if (management == ConsoleKey.UpArrow)
                    {
                        increment = increment - 1;
                        if (increment < 0) increment = 1;
                    } 
                    else if (management == ConsoleKey.DownArrow)
                    { 
                        increment = (increment + 1) % 2;
                    } 
                    else if (management == ConsoleKey.Enter)
                    {
                        if (increment == 0)
                        {
                            Console.CursorVisible = true;
                            Console.Clear();
                            diseThrower();
                        } 
                        else if (increment == 1)
                        {
                            Console.CursorVisible = true;
                            Console.Clear();
                            Setting();
                        }
                    }
                     if (increment == 0)
                    {
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write(' ');
                        Console.SetCursorPosition(Console.WindowWidth / 2 - start.Length / 2 - 2, 16);
                        Console.Write(arrow);
                    } else if (increment == 1)
                    {
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write(' ');
                        Console.SetCursorPosition(Console.WindowWidth / 2 - setting.Length / 2 - 2, 18);
                        Console.Write(arrow);
                    }

                }
                
            }

            void Setting()
            {
                Console.WriteLine("Coming soon!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            void diseThrower()
            {
                Random rnd = new Random();

                while (true)
                {
                    int d4 = rnd.Next(1, 4);
                    int d6 = rnd.Next(1, 6);
                    int d8 = rnd.Next(1, 8);
                    int d10 = rnd.Next(1, 10);
                    int d12 = rnd.Next(1, 12);
                    int d20 = rnd.Next(1, 20);
                    int d100 = rnd.Next(1, 100);
                    int reh;




                    {
                        Console.WriteLine("Приветствую тебя путник, какой кубик ты желаешь кинуть?");
                        Console.WriteLine("(Выберите номер под которым находится нужный вам кубик: )");
                        Console.WriteLine("1 - D4");
                        Console.WriteLine("2 - D6");
                        Console.WriteLine("3 - D8");
                        Console.WriteLine("4 - D10");
                        Console.WriteLine("5 - D12");
                        Console.WriteLine("6 - D20");
                        Console.WriteLine("7 - D100");
                        reh = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (reh == 1)
                        {

                            Console.WriteLine($"у вас выпало {d4}");
                        }
                        else if (reh == 2)
                        {
                            Console.WriteLine($"у вас выпало {d6}");
                        }
                        else if (reh == 3)
                        {
                            Console.WriteLine($"у вас выпало {d8}");
                        }
                        else if (reh == 4)
                        {
                            Console.WriteLine($"у вас выпало {d10}");
                        }
                        else if (reh == 5)
                        {
                            Console.WriteLine($"у вас выпало {d12}");
                        }
                        else if (reh == 6)
                        {
                            Console.WriteLine($"у вас выпало {d20}");
                        }
                        else if (reh == 7)
                        {
                            Console.WriteLine($"у вас выпало {d100}");
                        }

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
