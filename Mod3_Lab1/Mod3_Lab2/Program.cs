using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exception Handling

            double x = 98, y = 0;
            double result = 0;

            try
            {
                result = SafeDivision(x, y);
                Console.WriteLine($"The result of dividing {x} by {y} is {result}.");
            }
            // Catch most specific exceptions first.
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted to divide by zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Another exception was thrown.");
            }
        }

        #endregion

        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return x / y;
        }
    }
}

