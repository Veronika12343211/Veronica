using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_цифр_I_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine();
            number = int.Parse(Console.ReadLine());
            int sotni, a;
            int desytki,b;
            int edenitsy;
            int sum;

            sotni = number % 10;
            a = number / 10;
            desytki = a % 10;
            b = number / 10;
            edenitsy = b / 10;
            sum = sotni + desytki + edenitsy;
            Console.WriteLine(sum);
          

            Console.ReadLine();
        }
    }
}
