using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Laby1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is {result}");

            result = Sum(20, 40, 20);
            Console.WriteLine($"The sum of 20, 40 and 20 is {result}");

            result = (int)(Sum(20.5, 20.5));
            Console.WriteLine($"The result of 20.5 and 20.5 is {result}");
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }

        static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        static double Sum(double first, double second)
        {
            return first + second;
        }

    }
}
