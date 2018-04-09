using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_яблок_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples;
            Console.WriteLine();
            peoples = int.Parse(Console.ReadLine());

            int apples;
            Console.WriteLine();
            apples = int.Parse(Console.ReadLine());

            int ostatok;
            ostatok = peoples % apples;
            Console.WriteLine(ostatok);
            Console.ReadLine();
        }
    }
}
