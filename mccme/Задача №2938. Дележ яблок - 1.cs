using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_яблок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int apples;
            Console.WriteLine();
            apples = int.Parse(Console.ReadLine());
       
            Console.WriteLine();
            int peoples;
            peoples = int.Parse(Console.ReadLine());

            int will_get;
            will_get = peoples / apples;
            Console.WriteLine(will_get);
            Console.ReadLine();



        }
    }
}
