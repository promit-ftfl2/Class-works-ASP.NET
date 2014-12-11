using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("hi " +name  +" Good Day");
            Console.ReadKey();
        }
    }
}
