using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);

            string response;
            response = "connection success";

            // Switch statement
            switch (response)
            {
                case "connection success":
                    break;
                case "connection failed":
                    break;
                default:
                    break;
            }

            // For each loop
            string[] names = new string[10];
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            #region Loops

            // While loop
            while (response != "quit")
            {
                Console.WriteLine("Enter your response: ");
                response = Console.ReadLine();
            }

            // Do while loop
            int counter = 5;
            do
            {
                Console.WriteLine("Enter your second response: ");
                response = Console.ReadLine();
            } while (counter < 5);

            if (response == "quit") Console.WriteLine("I quit.");

            #endregion

            Console.WriteLine(Factorial(5));

            Console.WriteLine("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            printPrimeNumbers(findPrimeNumber());
        }

        // Factorial
        static long Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        static List<int> findPrimeNumber()
        {
            List<int> primeNumbersList = new List<int>();

            for (int i = 2; i < 100; i++)
            {
                int counter = 0;
                for (int j = 2; j < i + 1; j++)
                {
                    if (i % j == 0) counter++;
                }

                if (counter == 1) primeNumbersList.Add(i);
            }

            return primeNumbersList;
        }

        static void printPrimeNumbers(List<int> primeNumbersList)
        {
            foreach (int number in primeNumbersList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
