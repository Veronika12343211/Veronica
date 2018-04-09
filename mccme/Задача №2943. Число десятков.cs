using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Число_десятков_H_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine();
            number = int.Parse(Console.ReadLine());
            int shag1;
            int shag2;
            shag1 = number / 10;
            shag2 = shag1 % 10; 

            Console.WriteLine(shag2);

            Console.ReadLine();
        }
    }
}
