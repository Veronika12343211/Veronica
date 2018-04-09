using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Последняя_цифра
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine();
            number = int.Parse(Console.ReadLine());
            int poslednee_chislo;
            poslednee_chislo = number % 10;
            Console.WriteLine(poslednee_chislo);

            Console.ReadLine();
        }
    }
}
