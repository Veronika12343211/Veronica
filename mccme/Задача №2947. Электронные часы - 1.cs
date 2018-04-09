using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _K_Электронные_часы__1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int hour, minutes;
            hour = n / 60;
            minutes = n % 60;
            hour = hour + minutes/60;
            minutes = minutes % 60;
            hour = hour % 24;


            Console.WriteLine(hour+" "+ minutes);
            Console.ReadLine();
        }
    }
}
