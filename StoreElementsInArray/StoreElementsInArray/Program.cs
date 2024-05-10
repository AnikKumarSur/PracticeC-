/*Write a C# Sharp program that stores elements in an array and prints them.
Test Data:
Input 10 elements in the array:
element - 0 : 1
element - 1 : 1
element - 2 : 2
.......
Expected Output :
Elements in array are: 1 1 2 3 4 5 6 7 8 9*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("Input 10 elements in the array :");

            for( i=0;i<10;i++)
            {
                Console.Write("Element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array are : ");

            for( i=0; i<10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            Console.ReadLine();
        }
    }
}
