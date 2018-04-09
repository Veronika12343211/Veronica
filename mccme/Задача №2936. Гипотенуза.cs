using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write();
            a=int.Parse(Console.ReadLine());

            int b;
            Console.Write();
            b = int.Parse(Console.ReadLine());

            int hypotenuse = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            
            Console.WriteLine(hypotenuse);

            Console.ReadLine();
        }
    }
}
