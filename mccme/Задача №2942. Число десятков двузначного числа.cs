using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Число_десятков_двузначного_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine();
            number = int.Parse(Console.ReadLine());

            int chislo_desytkov;
            chislo_desytkov = number / 10;
            Console.WriteLine(chislo_desytkov);
            Console.ReadLine();
        }
    }
}
