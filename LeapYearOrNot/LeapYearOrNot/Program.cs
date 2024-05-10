/*Write a C# Sharp program to find out whether a given year is a leap year or not.
Test Data : 2016
Expected Output :
2016 is a leap year.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Data :");
            int testData = Convert.ToInt32(Console.ReadLine());

            if(testData%400==0)
            {
                Console.WriteLine("{0} is a leap year." , testData);
            }
            else if(testData%100 == 0)
            {
                Console.WriteLine("{0} is not leap year" , testData);
            }
            else if (testData%4 == 0)
            {
                Console.WriteLine("{0} is a leap Year" ,testData);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", testData);
            }

            Console.ReadKey();
        }
    }
}
