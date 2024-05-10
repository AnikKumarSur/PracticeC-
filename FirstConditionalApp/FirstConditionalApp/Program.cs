using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConditionalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first Number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber == secondNumber)
            {
                Console.WriteLine("{0} and {1} are equal . ", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal.", firstNumber , secondNumber );
            }
            Console.ReadKey();
        }
    }
}
