using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLimitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower limit:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper limit:");
            int u = Convert.ToInt32(Console.ReadLine());
            for (int i = l; i <= u; i++)
            {
                Console.WriteLine(""+i);
            }
            Console.ReadLine();


        }
    }
}
