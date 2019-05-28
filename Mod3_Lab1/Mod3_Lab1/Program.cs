using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // For 'out' only declaration is needed, for 'ref' initialization is needed.
            int first;
            string sValue;
            int a;
            ReturnMultiOut(out first, out sValue, out a);
            Console.WriteLine($"{first.ToString()}, {sValue}, {a}");

            int num1 = 0;
            string str1 = "";
            ReturnMultiRef(ref num1, ref str1);
            Console.WriteLine(num1.ToString() + " " + str1);

            StopService(true);

            // Named parameters
            StopService(true, serviceId: 2);
            Area(length: 25, width: 25);
        }

        // Return type is void
        static void ReturnMultiOut(out int i, out string s, out int j)
        {
            i = 25;
            s = "using out";
            j = 10;
        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 50;
            s = "using ref";
        }

        #region Method overloading 
        // Method must have unique signature (name + parameters)
        static void StopService()
        {

        }

        static void StopService(string serviceName)
        {

        }

        static void StopService(int serviceId)
        {

        }
        #endregion

        #region Optional parameters
        static void StopService(bool forceStop, string serviceName = "Super service", int serviceId = 1)
        {
            Console.WriteLine($"Service id: {serviceId}");
            Console.WriteLine("Service name: {0}", serviceName);
        }

        #endregion

        static void Area(int width, int length)
        {
            Console.WriteLine("The area is {0}", width * length);
        }
    }
}
