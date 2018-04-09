using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace М
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            a = int.Parse(Console.ReadLine());

            int b;
          
            b = int.Parse(Console.ReadLine());

            int n;
           
            n = int.Parse(Console.ReadLine());

            int ruble, kopek;
            ruble = a * n;
            kopek = (b * n);
            ruble = ruble + kopek / 100;
            kopek = kopek%100;

            Console.WriteLine(ruble + " " + kopek);
            Console.ReadLine();
        }
    }
}
