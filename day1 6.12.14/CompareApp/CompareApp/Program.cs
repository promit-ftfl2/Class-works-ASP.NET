using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
          
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("Small number is:" +a);
                Console.WriteLine("Large number is:" + b);

            }
            if (a > b)
            {
                Console.WriteLine("Small number is:" + b);
                Console.WriteLine("Large number is:" + a);

            }
            if (a==b)
            {
                Console.WriteLine("Both numbers are equal:" + a);
                

            }
            Console.ReadLine();
        }
    }
}
