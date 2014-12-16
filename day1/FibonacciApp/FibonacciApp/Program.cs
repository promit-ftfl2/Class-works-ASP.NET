using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int next=0; 
            for(int c=0;c<=100;c++)
            {
                if (next >= 100)
                {
                    break;
                }
                else if (c <= 1)
                {
                    next = c;
                   
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                    
                }
               
                Console.WriteLine("" + next);
                
                    
                
            }
            Console.ReadKey();
        }
    }
}
