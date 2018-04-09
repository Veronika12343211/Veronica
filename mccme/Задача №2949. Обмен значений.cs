using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M_Обмен_значений
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a +" "+ b);
            
            Console.ReadLine();






        }
    }
}
