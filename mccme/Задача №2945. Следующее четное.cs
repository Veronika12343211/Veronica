using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Следующее_четное_J_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine();
            number = int.Parse(Console.ReadLine());
            int chislo, even;
            chislo = number / 2;
            even = chislo * 2 + 2;
            Console.WriteLine(even);
            Console.ReadLine();


        }
    }
}
