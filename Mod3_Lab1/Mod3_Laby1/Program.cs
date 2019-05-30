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

            result = Convert.ToInt32(Sum(20.5, 20.5));
            Console.WriteLine($"The result of 20.5 and 20.5 is {result}");

            try
            {
                Divide(10, 0);
            }
            catch(Exception)
            {
                Console.WriteLine("Oops, divided by zero my friend");
            }
            finally
            {
                Console.WriteLine("does this display?");
            }

            Console.Write("Input a number: ");
            int firstNumberInput = Int32.Parse(Console.ReadLine());
            Console.Write("Input a second number: ");
            int secondNumberInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Divide(firstNumberInput, secondNumberInput));
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

        static int Divide(int first, int second)
        {
            if(second == 0)
            {
                throw new DivideByZeroException("Divide by zero.");
            }
            return first / second;
        }
    }
}
