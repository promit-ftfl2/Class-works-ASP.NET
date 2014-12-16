using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSquareApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double i = Convert.ToDouble(Console.ReadLine());
            double result = GetSquare(i);
            Console.WriteLine("Square of this number is:" +result);
            Console.ReadLine();
        }
        static double GetSquare(double aNum)
        {
            double square = aNum * aNum;
            return square;
        }
    }
}
