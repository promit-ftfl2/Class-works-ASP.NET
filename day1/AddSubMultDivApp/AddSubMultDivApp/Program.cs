using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubMultDivApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int no2 = Convert.ToInt32( Console.ReadLine());
            int add = no1 + no2;
            int sub = no1 - no2;
            int mult = no1*no2;
            int div = no1/no2;
            Console.WriteLine("Addition Result:" +add);
            Console.WriteLine("Subtraction Result:" +sub);
            Console.WriteLine("Multiplication Result:" +mult);
            Console.WriteLine("Division Result:" +div);
            Console.ReadKey();
        }
    }
}
