using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часы_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hours, minutes, seconds;
            hours = n / 3600;
            minutes = (n % 3600)/60;
            seconds =  (n % 3600) % 60;
            hours = hours + minutes / 3600;
            
            hours = hours % 24;
            minutes = minutes % 60;


            Console.WriteLine(hours + ":" + minutes+ ":"+seconds);
            Console.ReadLine();
        }
    }
}
