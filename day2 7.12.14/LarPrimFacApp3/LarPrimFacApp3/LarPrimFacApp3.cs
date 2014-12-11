using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarPrimFacApp3
{
    class LarPrimFacApp3
    {
        static void Main(string[] args)
        {
            Double num = 13195;
            long[] l = new long[100];
            int j = 0;
            for (int i = 2; i <= num/2; i++)
            {
                if ( num%i== 0)
                {
                    //Console.WriteLine("" +i);
                    l[j] = i;
                    j++;
                }

            }
            int a = l.Length;
            Console.WriteLine("" + a);
           // for (j = 0; j <= a; j++)
            {
                Console.WriteLine("" +l[j]);
            }
            Console.ReadKey();
        }
    }
}
