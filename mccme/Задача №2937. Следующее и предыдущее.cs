using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int number = int.Parse(Console.ReadLine());
            int next = number + 1;
            int previous = number - 1;
            Console.WriteLine("The next number for the number"+" " +number + " " + "is " +next);
            Console.WriteLine("The previous number for the number"+" " + number + " " + "is " + previous);
            Console.ReadLine();
            
        }
    }
}
