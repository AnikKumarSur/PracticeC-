using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test data : ");
            int testData = Convert.ToInt32(Console.ReadLine());

            if(testData%2==0)
            {
                Console.WriteLine("{0} The given number is even integer." , testData);
            }
            else
            {
                Console.WriteLine("{0} The given number is odd." , testData);
            }

            Console.ReadKey();
        }
    }
}
