using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int squared = 0;
            int result = 0;
            const int N = 100;

            
            for(int j=1;j<=N;j++)
            {
                 squared += j* j;
                sum = sum +j ;
            }
                    result = sum * sum - squared;
            Console.WriteLine(+result);
            Console.ReadKey();

        }
    }
}
