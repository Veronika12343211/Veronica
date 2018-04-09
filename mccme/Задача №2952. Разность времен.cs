using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обмен_значений
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours1 = int.Parse(Console.ReadLine());
            int minutes1 = int.Parse(Console.ReadLine());
            int seconds1 = int.Parse(Console.ReadLine());

            int hours2 = int.Parse(Console.ReadLine());
            int minutes2 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());



            hours1 = hours1 * 3600;
            minutes1 = minutes1 * 60;

            hours2 = hours2 * 3600;
            minutes2 = minutes2 * 60;

            seconds1 = hours1 + minutes1 + seconds1;
            seconds2 = hours2 + minutes2 + seconds2;

            seconds2 = seconds2 - seconds1;
            Console.WriteLine(seconds2);
            Console.ReadLine();


        }
    }
}
