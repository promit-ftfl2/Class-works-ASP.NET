using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
           
            for (int j=0; j < 100; j++)
            {
                i = j + 1;
                Console.WriteLine("" +i);
            }
            Console.ReadLine();
        }
    }
}
