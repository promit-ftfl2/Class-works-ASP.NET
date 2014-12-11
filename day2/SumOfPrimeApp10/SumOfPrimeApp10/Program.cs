using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimeApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 2;
            
            for(long i=3;i<=2000000;)
            {
                bool p = true;
                for (long j = 2; j <= i/2; j++)
                {
                    if(i%j==0)
                    {
                        p = false;
                    }
                    
                }
                if (p == true)
                {
                    sum = sum + i;
                }
                i += 2;
            }
            Console.WriteLine(+sum);
            Console.ReadKey();
        }
    }
}
