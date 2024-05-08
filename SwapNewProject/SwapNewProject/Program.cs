/*Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNewProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2, temp;

            Console.Write("Input The First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input The Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After Swapping");
            Console.WriteLine("The first Number : " +number1);
            Console.WriteLine("The Second Number : " + number2);

            Console.ReadKey();
        }
    }
}
