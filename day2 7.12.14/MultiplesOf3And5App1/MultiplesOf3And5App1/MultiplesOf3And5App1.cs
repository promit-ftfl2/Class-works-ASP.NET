using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5App1
{
    class MultiplesOf3And5App1
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    Sum = Sum + i;
                }
            }
            Console.WriteLine("" +Sum);
            Console.ReadKey();
        }
    }
}
