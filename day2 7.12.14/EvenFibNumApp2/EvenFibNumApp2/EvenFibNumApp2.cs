using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibNumApp2
{
    class EvenFibNumApp2
    {
        static void Main(string[] args)
        {
            int sum = 2, first = 1, second = 2, next;
            for (int c = 0; c < 100; c++)
            {
                if (sum > 4000000)
                {
                    break;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                    if (next%2 == 0)
                    {
                        sum = sum + next;
                    }
                }
            }
            Console.WriteLine("" +sum);
            Console.ReadKey();
        }
    }
}
