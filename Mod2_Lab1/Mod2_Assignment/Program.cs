using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolean = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (boolean) Console.Write("X");
                    else Console.Write("O");
                    if (j < 7) boolean = !boolean;
                }
                Console.Write("\n");
            }


        }
    }
}
