/*Write a C# Sharp program to check whether a given number is positive or negative.
Test Data : 14
Expected Output :
14 is a positive number*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Data :");
            int testData = Convert.ToInt32(Console.ReadLine());

            if (testData > 0)
            {
                Console.WriteLine("{0} the number is postive." , testData);
            }
            else
            {
                Console.WriteLine("{0} the number is negative.", testData);
            }

            Console.ReadKey();
               

        }
    }
}
