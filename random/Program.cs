using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next();
            Console.WriteLine(value);
        }
    }
}
